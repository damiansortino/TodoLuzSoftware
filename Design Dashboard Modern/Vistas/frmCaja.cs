using Design_Dashboard_Modern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class frmCaja : Form
    {
        Caja cajaabierta = new Caja();

        public frmCaja()
        {
            InitializeComponent();
        }

        private void frmCaja_Load(object sender, System.EventArgs e)
        {
            ComprobarCajas();

        }

        private void ComprobarCajas()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                if (CajaAbierta())
                {
                    RefrescarMovimientos();
                    RefrescarBotones();
                }
                else
                {
                    if (CajaSinCerrar())
                    {
                        MessageBox.Show("Debe cerrar la caja anterior para poder continuar");
                        CerrarCaja();
                    }

                    MessageBox.Show("La caja no está abierta todavía");
                    AbrirCaja();
                    ComprobarCajas();
                }
            }

        }

        private void RefrescarBotones()
        {
            if (!CajaAbierta())
            {
                btnCerrarCaja.Enabled = false;
            }

        }

        private void AbrirCaja()
        {
            popupAbrirCaja abrircaja = new popupAbrirCaja();
            abrircaja.ShowDialog();
        }

        private void CerrarCaja()
        {
            popupCierredeCaja cerrar = new popupCierredeCaja();
            cerrar.ShowDialog();

        }

        private bool CajaSinCerrar()
        {
            Caja registroactual = new Caja();

            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                registroactual = DB.Set<Caja>().OrderByDescending(t => t.CajaId).FirstOrDefault();
                if (registroactual.fechaCierreCaja == null) return true;
                else
                {
                    return false;
                }
            }
        }

        private void RefrescarMovimientos()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                Caja ultimcaja = DB.Set<Caja>().OrderByDescending(t => t.CajaId).FirstOrDefault();

                var lst = (from d in DB.movimientoCaja
                           join e in DB.Caja
                           on d.CajaId equals e.CajaId
                           where d.fechaBaja == null && e.CajaId == ultimcaja.CajaId
                           orderby d.MovimientoCajaId
                           select new
                           {
                               Fecha = d.fechaAlta,
                               Importe = d.importe,
                               Entra = d.entra,
                               Sale = d.sale,
                               Movimiento = d.observaciones
                           }).ToList();

                dgvVerCaja.DataSource = null;
                dgvVerCaja.DataSource = lst;

                cajaabierta = DB.Caja.ToList().Find(x => x.fechaCaja == DateTime.Now.Date && x.fechaCierreCaja == null);
                lblEfectivo.Text = cajaabierta.montoCaja.ToString();
            }

        }

        private bool CajaAbierta()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                List<Caja> abiertas = DB.Caja.ToList().FindAll(x => x.fechaCaja == DateTime.Now.Date && x.fechaCierreCaja == null);
                if (abiertas.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            CerrarCaja();
            this.Close();
        }

        private void btnMovCaja_Click(object sender, EventArgs e)
        {
            MovimientodeCaja(cajaabierta.CajaId);
            RefrescarMovimientos();
            RefrescarBotones();
        }

        private void MovimientodeCaja(int id)
        {
            popupMovimientodeCaja nuevomovcaja = new popupMovimientodeCaja(id);
            nuevomovcaja.ShowDialog();
        }
    }
}
