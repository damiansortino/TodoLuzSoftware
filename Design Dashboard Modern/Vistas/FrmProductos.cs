using Design_Dashboard_Modern.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class FrmProductos : Form
    {
        int bandera = 0;
        public FrmProductos()
        {
            InitializeComponent();
        }

        public FrmProductos(int a)
        {
            bandera = a;
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            if (bandera == 0)
            {
                Refrescar();
                pnBotonesCrud.Visible = true;
            }
            else
            {
                Refrescar();
                btnCopiarCodigo.Visible = true;
                btnCerrar.Visible = true;
            }

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
                           orderby e.Id descending
                           select new
                           {
                               IdProducto = e.Id,
                               Codigo = e.Codigo,
                               Precio = e.PrecioCosto + (e.PrecioCosto * e.Rentabilidad) / 100,
                               Disponible = d.cantidad,
                               Nombre = e.Nombre,
                               Descripción = e.Descripcion,
                               Marca = e.Marca,
                               Modelo = e.Modelo,
                               Color = e.Color

                           }).ToList();


                Buscar.DataSource = lst;
                Buscar.Columns[0].Visible = false;
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
                           where e.FechaBaja == null && ((e.Nombre.Contains(filtro) || e.Codigo.Contains(filtro))) || e.Marca.Contains(filtro)
                           orderby e.Id ascending
                           select new
                           {
                               IdProducto = e.Id,
                               Codigo = e.Codigo,
                               Precio = e.PrecioCosto + (e.PrecioCosto * e.Rentabilidad) / 100,
                               Disponible = d.cantidad,
                               Nombre = e.Nombre,
                               Marca = e.Marca,
                               Modelo = e.Modelo,
                               Color = e.Color

                           }).ToList();

                Buscar.DataSource = lst;
                Buscar.Columns[0].Visible = false;

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)Buscar.CurrentRow.Cells[0].Value;

                FrmAgregarProducto modificar = new FrmAgregarProducto(id);
                modificar.ShowDialog();
                Refrescar();

            }
            catch (Exception)
            {
                MessageBox.Show("Error, debe seleccionar un producto primero para modificar");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbFiltro.TextLength < 1)
            {
                MessageBox.Show("Debe escribir algún criterio de búsqueda primero");
            }
            else
            {
                BuscaFiltro(tbFiltro.Text.Trim());
            }
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

        private void btnCopiarCodigo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Buscar.Rows[Buscar.CurrentRow.Index].Cells[1].Value.ToString());
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
