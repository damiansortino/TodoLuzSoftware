using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.Models;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class popupAbrirCaja : Form
    {
        public popupAbrirCaja()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbImporte.TextLength < 1) tbImporte.Text = "0";

            double importecaja = 0;

            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                Caja nuevacaja = new Caja();
                nuevacaja.fechaCaja = DateTime.Now.Date;
                nuevacaja.montoCaja = double.Parse(tbImporte.Text);
                DB.Caja.Add(nuevacaja);
                DB.SaveChanges();
                importecaja = double.Parse(tbImporte.Text);

                var registroMasActualizado = DB.Set<Caja>().OrderByDescending(t => t.CajaId).FirstOrDefault();

                movimientoCaja movcaja = new movimientoCaja();
                movcaja.fechaAlta = DateTime.Now;
                movcaja.CajaId = registroMasActualizado.CajaId;
                movcaja.entra = true;
                movcaja.sale = false;
                movcaja.importe = importecaja;
                movcaja.tipoMovimientoCajaId = 1;
                movcaja.observaciones = "Caja Inicial";
                DB.movimientoCaja.Add(movcaja);
                DB.SaveChanges();
            }

            MessageBox.Show("La caja fue abierta correctamente con un importe de $ "+importecaja);
        }

        private void tbImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (char.IsPunctuation(e.KeyChar) && (e.KeyChar != '.'))) e.Handled = true;
        }

        private void popupAbrirCaja_Load(object sender, EventArgs e)
        {
            tbImporte.Text = "0";
        }

        private void tbImporte_Enter(object sender, EventArgs e)
        {
            tbImporte.Clear();
        }

        private void tbImporte_Leave(object sender, EventArgs e)
        {
            if (tbImporte.TextLength < 1) tbImporte.Text = "0";
        }
    }
}
