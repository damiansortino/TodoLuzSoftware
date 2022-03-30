using Design_Dashboard_Modern.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                string spass = Encrypt.GetSHA256(tbContraseña.Text.Trim());
                var lst = from d in DB.Usuario
                          where (d.UserName == tbUsuario.Text && d.Pass == spass)
                          select d;


                if (lst.Count() > 0)
                {

                    Usuario usuariolog = DB.Usuario.ToList().Find(x => x.UserName.ToUpper() == tbUsuario.Text.ToUpper());


                    if (usuariolog.EmailConfirmed != false)
                    {
                        UsuarioActivo.ApellidoyNombre = usuariolog.ApellidoyNombre;
                        UsuarioActivo.Id = usuariolog.Id;
                        UsuarioActivo.TipoUsuario = usuariolog.TipoUser;

                        this.Hide();
                        Main programa = new Main();
                        programa.FormClosed += (s, args) => this.Close();
                        programa.Show();
                    }
                    else
                    {
                        popupBlanqueoClave blanquear = new popupBlanqueoClave(usuariolog.Id);
                        blanquear.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario No encontrado");
                }
            }
        }

        private void linkCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAgregarUsuario nuevousuario = new frmAgregarUsuario();
            nuevousuario.ShowDialog();
        }

        private void tbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
