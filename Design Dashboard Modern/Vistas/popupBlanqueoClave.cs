using System;
using System.Windows.Forms;
using Design_Dashboard_Modern.Models;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class popupBlanqueoClave : Form
    {
        int iduser = 0;
        public popupBlanqueoClave()
        {
            InitializeComponent();
        }

        public popupBlanqueoClave(int h)
        {
            InitializeComponent();
            iduser = h;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                if (ComprobarCampos())
                {
                    Usuario usuario = DB.Usuario.Find(iduser);
                    usuario.EmailConfirmed = true;
                    usuario.Pass = Encrypt.GetSHA256(tbPass1.Text.Trim());
                    DB.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                    MessageBox.Show("Su contraseña ha sido actualizada correctamente, reinicie el programa para ingresar");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Sus contraseñas no coinciden o son muy cortas, escríbalas nuevamente");
                    tbPass1.Clear();
                    tbPass2.Clear();
                    tbPass1.Focus();
                }
            }
        }

        private bool ComprobarCampos()
        {
            if((Encrypt.GetSHA256(tbPass1.Text.Trim()) == Encrypt.GetSHA256(tbPass2.Text.Trim()))&&tbPass1.Text.Length>=4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void popupBlanqueoClave_Load(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                lblSaludo.Text = "Bienvenido, " + DB.Usuario.Find(iduser).ApellidoyNombre;
            }
        }
    }
}
