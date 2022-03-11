using Design_Dashboard_Modern.Models;
using System;
using System.Windows.Forms;


namespace Design_Dashboard_Modern.Vistas
{
    public partial class popupCambiarTipoUsuario : Form
    {
        int usuarioid = 0;
        Usuario usuario = new Usuario();
        public popupCambiarTipoUsuario()
        {
            InitializeComponent();
        }
        public popupCambiarTipoUsuario(int i)
        {
            InitializeComponent();
            usuarioid = i;
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                usuario = DB.Usuario.Find(usuarioid);

            }
        }

        private void popupCambiarTipoUsuario_Load(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                lblNombre.Text = usuario.ApellidoyNombre;
                lblTipoUer.Text = usuario.TipoUser;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                if ((cboxTipoUsuario.Text == "Administrador"
                    || cboxTipoUsuario.Text == "Master")
                    && (tbLlaveMaestra.Text == "TodoLuz12"))
                {
                    usuario.TipoUser = cboxTipoUsuario.Text;
                    DB.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                    MessageBox.Show("Rol de usuario modificado correctamente");
                    this.Close();
                }
                else
                {
                    if (cboxTipoUsuario.Text != "Administrador" && cboxTipoUsuario.Text != "Master")
                    {
                        usuario.TipoUser = cboxTipoUsuario.Text;
                        DB.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                        MessageBox.Show("Rol de usuario modificado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La llave es incorrecta, intente nuevamente");
                        tbLlaveMaestra.Clear();
                        tbLlaveMaestra.Focus();

                    }

                }
            }
        }

        private void tbLlaveMaestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(e.KeyChar) == Convert.ToChar(Keys.Enter)) btnCambiar.PerformClick();
        }

        private void cboxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTipoUsuario.Text == "Administrador" || cboxTipoUsuario.Text == "Master")
            {
                panelLlaveMaestra.Visible = true;
            }
            else
            {
                panelLlaveMaestra.Visible = false;
            }
        }
    }
}
