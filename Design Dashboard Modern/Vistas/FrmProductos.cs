using Design_Dashboard_Modern.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Refrescar();
            pnBotonesCrud.Visible = true;
        }

        #region Helper
        private void Refrescar()
        {
            dgvVerProductos.DataSource = null;

            using (todoluzdbEntities db = new todoluzdbEntities())
            {
                var lst = from d in db.Producto select d;

                //List<Producto> productosnuevos = from Producto in db.Producto;
                List<Producto> products = lst.ToList();
                products = products.FindAll(x => x.FechaBaja == null);

                dgvVerProductos.DataSource = products;
            }
            dgvVerProductos.Visible = true;
        }
        private void AbrirFormHijo(Object formhijo)
        {
            if (this.split.Panel2.Controls.Count > 0) this.split.Panel2.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.split.Panel2.Controls.Add(fh);
            this.split.Panel2.Tag = fh;
            fh.Show();
        }
        private int? GetId()
        {
            try
            {
                return int.Parse(dgvVerProductos.Rows[dgvVerProductos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto agregar = new FrmAgregarProducto();
            agregar.ShowDialog();
        }

        private void FrmProductos_Enter(object sender, EventArgs e)
        {
            Refrescar();
            pnBotonesCrud.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmAgregarProducto modificar = new FrmAgregarProducto(id);
                modificar.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (todoluzdbEntities db = new todoluzdbEntities())
                {
                    Producto prod = db.Producto.Find(id);
                    prod.FechaBaja = DateTime.Now;

                    db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("El producto ha sido eliminado correctamente");
                    Refrescar();
                }
            }

        }

    }
}
