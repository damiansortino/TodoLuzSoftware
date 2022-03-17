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
    public partial class popupMovimientodeCaja : Form
    {
        int idCaja = 0;
        public popupMovimientodeCaja()
        {
            InitializeComponent();
        }
        public popupMovimientodeCaja(int v)
        {
            InitializeComponent();
            idCaja = v;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupMovimientodeCaja_Load(object sender, EventArgs e)
        {
            LlenarCombobox();
        }

        private void LlenarCombobox()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                cboxTipoMov.DisplayMember = "nombreTipoMovimientoCaja";
                cboxTipoMov.ValueMember = "TipoMovimientoCajaId";
                cboxTipoMov.DataSource = DB.tipoMovimientoCaja.ToList();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((rbtnEntra.Checked == true || rbtnSale.Checked == true) && tbImporte.TextLength>0)
            {
                GenerarMovCaja();
                ActualizarCaja();
                MessageBox.Show("Movimiento cargado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Primero debe completar todos los campos");
            }
        }

        private void ActualizarCaja()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                Caja actualizar = DB.Caja.Find(idCaja);
                if(rbtnEntra.Checked == true)
                {
                    actualizar.montoCaja = double.Parse(tbImporte.Text) + actualizar.montoCaja;
                }
                else
                {
                    actualizar.montoCaja = actualizar.montoCaja - double.Parse(tbImporte.Text);
                }
                
                DB.Entry(actualizar).State = System.Data.Entity.EntityState.Modified;

                DB.SaveChanges();
            }
        }

        private void GenerarMovCaja()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                movimientoCaja nmc = new movimientoCaja();
                nmc.CajaId = idCaja;
                nmc.fechaAlta = DateTime.Now;
                nmc.importe = double.Parse(tbImporte.Text);
                nmc.tipoMovimientoCajaId = (int)cboxTipoMov.SelectedValue;
                nmc.observaciones = DB.tipoMovimientoCaja.Find(nmc.tipoMovimientoCajaId).nombreTipoMovimientoCaja;
                                
                if(rbtnEntra.Checked == true)
                {
                    nmc.entra = true;
                    nmc.sale = false;
                }
                else
                {
                    nmc.entra = false;
                    nmc.sale = true;
                }

                DB.movimientoCaja.Add(nmc);
                DB.SaveChanges();
            }

        }

        private void tbImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
