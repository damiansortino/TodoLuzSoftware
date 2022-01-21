using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Design_Dashboard_Modern.Models;

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
                dgvMuestraTiposMovStock.DataSource = DB.tipoMovimientoStock.ToList();
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

        
    }
}
