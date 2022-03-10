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
            tbFiltro.Clear();
            tbFiltro.Focus();
            panCrud.Visible = false;
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
                if (v == "todas") dgvVerVentas.DataSource = lst;
                if (v == "dia") dgvVerVentas.DataSource = lst.FindAll(x => x.Fecha.Date == DateTime.Now.Date);
                if (v == "mes") dgvVerVentas.DataSource = lst.FindAll(x => x.Fecha.Month == DateTime.Now.Month);
                if (v == "semana") dgvVerVentas.DataSource = lst.FindAll(x => (x.Fecha.Date == DateTime.Now.Date) || (x.Fecha.Date > DateTime.Today.AddDays(-8)));
            }
            panCrud.Visible = false;
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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                using (todoluzdbEntities DB = new todoluzdbEntities())
                {
                    comprobante modificar = DB.comprobante.ToList().Find(x => x.codigo
                    == (string)dgvVerVentas.CurrentRow.Cells[1].Value);

                    modificar.fechaBaja = DateTime.Now;
                    DB.Entry(modificar).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();

                    foreach (detalleFactura item in DB.detalleFactura.ToList().FindAll(X => X.fechaBaja == null))
                    {
                        if (modificar.Id == item.ComprobanteId)
                        {
                            int stockid = 0;

                            item.fechaBaja = modificar.fechaBaja;

                            DB.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            DB.SaveChanges();

                            foreach (Stock stock in DB.Stock.ToList())
                            {
                                if (stock.ProductoId == item.ProductoId)
                                {
                                    stock.cantidad = stock.cantidad + item.cantidad;
                                    stockid = stock.StockId;
                                    DB.Entry(stock).State = System.Data.Entity.EntityState.Modified;
                                    DB.SaveChanges();
                                }
                            }

                            movimientoStock nuevomovstock = new movimientoStock();
                            nuevomovstock.cantidad = item.cantidad;
                            nuevomovstock.ComprobanteId = modificar.Id;
                            nuevomovstock.descripcion = "Anulación de Venta";
                            nuevomovstock.entra = true;
                            nuevomovstock.sale = false;
                            nuevomovstock.fechaAlta = DateTime.Now;
                            nuevomovstock.StockId = stockid;
                            nuevomovstock.TipoMovimientoStockId = 1007;
                            DB.movimientoStock.Add(nuevomovstock);
                            DB.SaveChanges();
                        }
                    }

                }
                MessageBox.Show("Venta eliminada correctamente");
                MuestraVentas("todas");
                panCrud.Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al anular la venta");
            }

        }

        private void dgvVerVentas_MouseClick(object sender, MouseEventArgs e)
        {
            panCrud.Visible = true;
        }
    }
}
