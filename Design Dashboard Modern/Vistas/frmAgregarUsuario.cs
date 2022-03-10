using Design_Dashboard_Modern.Models;
using System;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbTipoUser.Text == "Administrador")
            {
                if (tbContraseñaMaestra.Text == "TodoLuz12")
                {
                    if (ValidarCampos())
                    {
                        using (todoluzdbEntities DB = new todoluzdbEntities())
                        {
                            Usuario nuevo = new Usuario();
                            nuevo.UserName = tbUsuario.Text;
                            nuevo.Pass = Encrypt.GetSHA256(tbContraseña.Text);
                            nuevo.Email = tbMail.Text;
                            nuevo.ApellidoyNombre = tbApellidoyNombre.Text;
                            nuevo.DNI = tbDNI.Text;
                            nuevo.FechadeNac = dtpFechaNac.Value.ToString();
                            nuevo.Direccion = tbDireccion.Text;
                            nuevo.Telefono = tbTelefono.Text;
                            nuevo.TipoUser = cbTipoUser.Text;
                            nuevo.FechaAlta = System.DateTime.Now;

                            DB.Usuario.Add(nuevo);
                            DB.SaveChanges();

                            MessageBox.Show("Usuario Agregado Correctamente");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar todos los datos para poder crear" +
                            " un nuevo usuario y el nombre de usuario debe ser mayor a 3 caracteres.");
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña Master es incorrecta, no puede crear usuarios administradores");
                }
            }

            if (ValidarCampos())
            {
                using (todoluzdbEntities DB = new todoluzdbEntities())
                {
                    Usuario nuevo = new Usuario();
                    nuevo.UserName = tbUsuario.Text;
                    nuevo.Pass = Encrypt.GetSHA256(tbContraseña.Text);
                    nuevo.Email = tbMail.Text;
                    nuevo.ApellidoyNombre = tbApellidoyNombre.Text;
                    nuevo.DNI = tbDNI.Text;
                    nuevo.FechadeNac = dtpFechaNac.Value.ToString();
                    nuevo.Direccion = tbDireccion.Text;
                    nuevo.Telefono = tbTelefono.Text;
                    nuevo.TipoUser = cbTipoUser.Text;
                    nuevo.FechaAlta = System.DateTime.Now;

                    DB.Usuario.Add(nuevo);
                    DB.SaveChanges();

                    MessageBox.Show("Usuario Agregado Correctamente");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos para poder crear" +
                    " un nuevo usuario y el nombre de usuario debe ser mayor a 3 caracteres.");
            }
        }

        private bool ValidarCampos()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item.Text == string.Empty) return false;
            }

            if (tbUsuario.TextLength < 3) return false;

            return true;
        }

        private void cbTipoUser_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoUser.Text == "Administrador")
            {
                lblContraseñaMaestra.Visible = true;
                tbContraseñaMaestra.Visible = true;
            }
            else
            {
                lblContraseñaMaestra.Visible = false;
                tbContraseñaMaestra.Visible = false;
            }
        }

        private void tbContraseñaMaestra_Enter(object sender, EventArgs e)
        {
            tbContraseña.Clear();
        }

        private void tbContraseñaMaestra_Leave(object sender, EventArgs e)
        {
            if (tbContraseñaMaestra.Text != "TodoLuz12") tbContraseñaMaestra.Clear();
        }
    }
}
