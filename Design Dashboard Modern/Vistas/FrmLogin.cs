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
using System.Linq;

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
                          where d.UserName == tbUsuario.Text && d.Pass == spass
                          select d;

                
                if (lst.Count()>0)
                {
                    //UsuarioActivo activo = new UsuarioActivo();
                    Usuario usuariolog = DB.Usuario.ToList().FindAll(x => x.UserName == tbUsuario.Text)[0];
                    UsuarioActivo.ApellidoyNombre = usuariolog.ApellidoyNombre;
                    UsuarioActivo.Id = usuariolog.Id;
                    UsuarioActivo.TipoUsuario = usuariolog.TipoUser;

                    this.Hide();
                    Main programa = new Main();
                    programa.FormClosed += (s,args) => this.Close();
                    programa.Show();

                    MessageBox.Show("Bienvenido "+UsuarioActivo.ApellidoyNombre);

                    /*
                    activo.ApellidoyNombre = usuariolog.ApellidoyNombre;
                    activo.Id = usuariolog.Id;
                    activo.TipoUsuario = usuariolog.TipoUser;

                    MessageBox.Show("Inicio correcto con usuario " + activo.ApellidoyNombre);
                    */
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
    }
}
