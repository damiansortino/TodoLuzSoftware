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
                
                editar = DB.tipoMovimientoStock.ToList().Find(x=>x.TipoMovimientoStockId ==editar.TipoMovimientoStockId);
                editar.nombreTipoMovimientoStock = tbNombreMovStock.Text;

                DB.Entry(editar).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                MessageBox.Show("El movimiento ha sido modificado correctamente");
                this.Close();
            }
        }
    }
}
