using Design_Dashboard_Modern.Models;
using System;
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
            RefrescarUsuarios();
            RefrescarTipoMovCaja();

            if (UsuarioActivo.TipoUsuario != "Master")
            {
                btnModMovCaja.Visible = false;
                btnEliminiarMovCaja.Visible = false;
            }


        }

        private void RefrescarTipoMovCaja()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                dgvMuestraMovCaja.DataSource = null;
                dgvMuestraMovCaja.DataSource = DB.tipoMovimientoCaja.ToList();
                dgvMuestraMovCaja.Columns[0].Visible = false;
                dgvMuestraMovCaja.Columns[1].HeaderText = "Movimiento";
            }
        }

        private void RefrescarUsuarios()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                var lst = (from d in DB.Usuario
                           where d.FechaBaja == null
                           orderby d.Id descending
                           select new
                           {
                               Nombre = d.ApellidoyNombre,
                               Username = d.UserName,
                               TipodeUsuario = d.TipoUser,
                               DNI = d.DNI,
                               FechadeNacimiento = d.FechadeNac,
                               Teléfono = d.Telefono,
                               Direccion = d.Direccion,
                               Id = d.Id

                           }).ToList();
                dgvMuestraUsuarios.DataSource = null;
                dgvMuestraUsuarios.DataSource = lst;
                dgvMuestraUsuarios.Columns[7].Visible = false;

            }
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

        private void btnAgregaUsuario_Click(object sender, System.EventArgs e)
        {
            frmAgregarUsuario agregarusuario = new frmAgregarUsuario();
            agregarusuario.ShowDialog();
            RefrescarUsuarios();
        }

        private void btnEliminaUsuario_Click(object sender, System.EventArgs e)
        {

            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                Usuario usuarioelim = DB.Usuario.ToList().Find(x => x.UserName
                == (string)dgvMuestraUsuarios.CurrentRow.Cells[1].Value);

                usuarioelim.FechaBaja = System.DateTime.Now;
                DB.Entry(usuarioelim).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();

                RefrescarUsuarios();
                MessageBox.Show("Usuario eliminado Correctamente");

            }
        }

        private void btnBlanquearClave_Click(object sender, System.EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                Usuario userblanquear = DB.Usuario.ToList().Find(x => x.UserName
                == (string)dgvMuestraUsuarios.CurrentRow.Cells[1].Value);
                userblanquear.EmailConfirmed = false;
                userblanquear.Pass = Encrypt.GetSHA256(userblanquear.DNI.Substring(userblanquear.DNI.Length - 4
                    , 4));

                DB.Entry(userblanquear).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                MessageBox.Show("El usuario ha sido blanqueado correctamente" +
                    ", deberá cambiar su contraseña en el próximo ingreso");
            }
        }

        private void btnCambiarTipoUser_Click(object sender, System.EventArgs e)
        {
            popupCambiarTipoUsuario cambiousuario = new popupCambiarTipoUsuario((int)dgvMuestraUsuarios.CurrentRow.Cells[7].Value);
            cambiousuario.ShowDialog();
            RefrescarUsuarios();
        }

        private void btnAgregarMovCaja_Click(object sender, EventArgs e)
        {
            try
            {
                popupNuevoTipoMovCaja agregarmovcaja = new popupNuevoTipoMovCaja();
                agregarmovcaja.ShowDialog();
                RefrescarTipoMovCaja();
            }
            catch (Exception)
            {
                MessageBox.Show("Error agregando de movimiento de caja");
            }
        }
    }
}
