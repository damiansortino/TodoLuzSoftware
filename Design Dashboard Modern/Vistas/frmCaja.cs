using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Design_Dashboard_Modern.Models;

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
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                if (CajaAbierta())
                {
                    cajaabierta = DB.Caja.ToList().Find(x => x.fechaCaja == DateTime.Now.Date && x.fechaCierreCaja == null);
                    lblEfectivo.Text = cajaabierta.montoCaja.ToString();
                    RefrescarMovimientos();

                }
                else
                {
                    MessageBox.Show("La caja no está abierta todavía");
                }
            }

        }

        private void RefrescarMovimientos()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                var lst = (from d in DB.movimientoCaja
                           join e in DB.Caja
                           on d.CajaId equals e.CajaId
                           where d.fechaBaja == null
                           orderby d.MovimientoCajaId
                           select new
                           {
                               Fecha = d.fechaAlta,
                               Importe = d.importe,
                               Movimiento = d.observaciones
                           }).ToList();

                dgvVerCaja.DataSource = null;
                dgvVerCaja.DataSource = lst;

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
    }
}
