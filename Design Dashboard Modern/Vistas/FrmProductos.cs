using Design_Dashboard_Modern.Models;
using System;
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
            Buscar.DataSource = null;

            using (todoluzdbEntities db = new todoluzdbEntities())
            {
                var lst = (from d in db.Stock
                           join e in db.Producto
                           on d.ProductoId equals e.Id
                           where e.FechaBaja == null
                           orderby e.Id ascending
                           select new
                           {
                               Codigo = e.Codigo,
                               Nombre = e.Nombre,
                               Marca = e.Marca,
                               Modelo = e.Modelo,
                               Color = e.Color,
                               Precio = e.PrecioCosto + (e.PrecioCosto * e.Rentabilidad) / 100,
                               Disponible = d.cantidad
                           }).ToList();

                Buscar.DataSource = lst;
            }
            Buscar.Visible = true;
        }

        private void BuscaFiltro(string filtro)
        {
            Buscar.DataSource = null;

            using (todoluzdbEntities db = new todoluzdbEntities())
            {
                var lst = (from d in db.Stock
                           join e in db.Producto
                           on d.ProductoId equals e.Id
                           where e.FechaBaja == null && (e.Nombre.Contains(filtro) || e.Codigo.Contains(filtro))
                           orderby e.Id ascending
                           select new
                           {
                               Codigo = e.Codigo,
                               Nombre = e.Nombre,
                               Marca = e.Marca,
                               Modelo = e.Modelo,
                               Color = e.Color,
                               Precio = e.PrecioCosto + (e.PrecioCosto * e.Rentabilidad) / 100,
                               Disponible = d.cantidad
                           }).ToList();

                Buscar.DataSource = lst;
            }
            Buscar.Visible = true;
        }




        private int? GetId()
        {
            try
            {
                return int.Parse(Buscar.Rows[Buscar.CurrentRow.Index].Cells[0].Value.ToString());
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
            Refrescar();
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
            Refrescar();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscaFiltro(tbFiltro.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void tbFiltro_Enter(object sender, EventArgs e)
        {
            tbFiltro.Text = "";
        }

        private void tbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnBuscar.PerformClick();
            }
        }
    }
}
