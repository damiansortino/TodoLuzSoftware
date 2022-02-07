using Design_Dashboard_Modern.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Usuario nuevo = new Usuario();

            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
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

    }
}
