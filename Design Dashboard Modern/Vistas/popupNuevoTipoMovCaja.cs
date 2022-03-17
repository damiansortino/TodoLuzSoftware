using Design_Dashboard_Modern.Models;
using System;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class popupNuevoTipoMovCaja : Form
    {
        public popupNuevoTipoMovCaja()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                tipoMovimientoCaja nuevomovcaja = new tipoMovimientoCaja();
                nuevomovcaja.nombreTipoMovimientoCaja = tbNombreMovCaja.Text;

                DB.tipoMovimientoCaja.Add(nuevomovcaja);
                DB.SaveChanges();
                MessageBox.Show("Tipo de movimiento agregado correctamente");
                this.Close();
            }
        }
    }
}
