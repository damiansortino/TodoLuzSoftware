using Design_Dashboard_Modern.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class frmVerVentas : Form
    {
        public frmVerVentas()
        {
            InitializeComponent();
        }

        private void frmVerVentas_Load(object sender, EventArgs e)
        {
            MuestraVentas("todas");
        }

        private void MuestraVentas(string v)
        {
            using (todoluzdbEntities db = new todoluzdbEntities())
            {
                var lst1 = (from d in db.comprobante
                           join e in db.Usuario
                           on d.UserId equals e.Id 
                           where d.fechaBaja == null
                           orderby d.fechaAlta descending
                           select new
                           {
                               Fecha = d.fechaAlta,
                               Código = d.codigo,
                               Vendedor = e.ApellidoyNombre,
                               Cliente = d.ClienteId,
                               Importe = d.importe,
                           }).ToList();

                var lst = (from d in lst1
                           join e in db.Cliente
                           on d.Cliente equals e.Id
                           orderby d.Fecha descending
                           select new
                           {
                               Fecha = d.Fecha,
                               Código = d.Código,
                               Vendedor = d.Vendedor,
                               Cliente = e.NombreyApellido,
                               Importe = d.Importe,
                           }).ToList();

                dgvVerVentas.DataSource = null;
                if(v == "todas") dgvVerVentas.DataSource = lst;
                if (v == "dia") dgvVerVentas.DataSource = lst.FindAll(x=>x.Fecha.Date == DateTime.Now.Date);
                if (v == "mes") dgvVerVentas.DataSource = lst.FindAll(x => x.Fecha.Month == DateTime.Now.Month);
                if (v == "semana") dgvVerVentas.DataSource = lst.FindAll(x => x.Fecha.Day >= DateTime.Now.Day-7);
            }
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            MuestraVentas("todas");
        }

        private void btnVentasDia_Click(object sender, EventArgs e)
        {
            MuestraVentas("dia");
        }

        private void btnVentasSemana_Click(object sender, EventArgs e)
        {
            MuestraVentas("semana");
        }

        private void btnVentasMes_Click(object sender, EventArgs e)
        {
            MuestraVentas("mes");
        }
    }
}
