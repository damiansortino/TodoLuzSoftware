using Design_Dashboard_Modern.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class popupEditarTipoMovStock : Form
    {
        tipoMovimientoStock editar = new tipoMovimientoStock();

        public popupEditarTipoMovStock(int idparaeditar)
        {
            InitializeComponent();
            editar.TipoMovimientoStockId = idparaeditar;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {

                editar = DB.tipoMovimientoStock.ToList().Find(x => x.TipoMovimientoStockId == editar.TipoMovimientoStockId);
                editar.nombreTipoMovimientoStock = tbNombreMovStock.Text;

                DB.Entry(editar).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                MessageBox.Show("El movimiento ha sido modificado correctamente");
                this.Close();
            }
        }
    }
}
