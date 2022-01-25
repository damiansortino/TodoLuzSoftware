using Design_Dashboard_Modern.Models;
using System;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class popupNuevoTipoMovStock : Form
    {
        public popupNuevoTipoMovStock()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                tipoMovimientoStock nuevomovstock = new tipoMovimientoStock();
                nuevomovstock.nombreTipoMovimientoStock = tbNombreMovStock.Text;

                DB.tipoMovimientoStock.Add(nuevomovstock);
                DB.SaveChanges();
                MessageBox.Show("Tipo de movimiento agregado correctamente");
                this.Close();
            }
        }
    }
}
