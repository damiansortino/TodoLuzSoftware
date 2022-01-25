using Design_Dashboard_Modern.Models;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }
        private void frmConfiguracion_Load(object sender, System.EventArgs e)
        {
            RefrescarTipoMov();
        }

        private void btnAgregarMovStock_Click(object sender, System.EventArgs e)
        {
            popupNuevoTipoMovStock nuevomovstock = new popupNuevoTipoMovStock();
            nuevomovstock.ShowDialog();
            RefrescarTipoMov();
        }
        #region Helper
        private void RefrescarTipoMov()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                dgvMuestraTiposMovStock.DataSource = DB.tipoMovimientoStock.ToList().FindAll(x => x.fechaBaja == null);
                dgvMuestraTiposMovStock.Columns[0].Visible = false;
                dgvMuestraTiposMovStock.Columns[2].Visible = false;
                dgvMuestraTiposMovStock.Columns[3].Visible = false;
                dgvMuestraTiposMovStock.Columns[1].HeaderText = "Nombre";
            }
        }

        #endregion
        private void btnModificarMovStock_Click(object sender, System.EventArgs e)
        {
            int ideditar = (int)dgvMuestraTiposMovStock.CurrentRow.Cells[0].Value;
            popupEditarTipoMovStock editarmovstock = new popupEditarTipoMovStock(ideditar);
            editarmovstock.ShowDialog();
            RefrescarTipoMov();
        }

        private void btnBorrarMovStock_Click(object sender, System.EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                tipoMovimientoStock eliminar = (tipoMovimientoStock)dgvMuestraTiposMovStock.CurrentRow.DataBoundItem;
                eliminar.fechaBaja = System.DateTime.Now;

                DB.Entry(eliminar).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                MessageBox.Show("Movimiento eliminado");
                btnBorrarMovStock.Enabled = false;
            }
        }

        private void dgvMuestraTiposMovStock_Click(object sender, System.EventArgs e)
        {
            btnBorrarMovStock.Enabled = true;
            btnModificarMovStock.Enabled = true;
        }
    }
}
