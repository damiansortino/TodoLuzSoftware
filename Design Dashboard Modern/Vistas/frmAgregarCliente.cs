using Design_Dashboard_Modern.Models;
using System;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class frmAgregarCliente : Form
    {
        public int? identificacion { get; set; }
        Cliente editar = new Cliente();

        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        public frmAgregarCliente(int? id = 0)
        {
            InitializeComponent();
            identificacion = id;

            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                editar = DB.Cliente.Find(identificacion);
            }

            tbApellidoyNombre.Text = editar.NombreyApellido;
            tbDireccion.Text = editar.direccion;
            tbTel.Text = editar.numeroTelefono;
            tbDNI.Text = editar.DNI;
            dtpFechaNac.Value = editar.FechaNac.Value.Date;
            tbEmail.Text = editar.email;
            tbCuitCuil.Text = editar.cuit;
            tbRentabilidad.Text = editar.porcentajeRentabilidad.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (identificacion == null)
            {
                Cliente agregar = new Cliente();
                using (todoluzdbEntities DB = new todoluzdbEntities())
                {
                    agregar.NombreyApellido = tbApellidoyNombre.Text.ToUpper();
                    agregar.DNI = tbDNI.Text.ToUpper();
                    agregar.direccion = tbDireccion.Text.ToUpper();
                    agregar.numeroTelefono = tbTel.Text;
                    agregar.email = tbEmail.Text;
                    agregar.FechaNac = dtpFechaNac.Value;
                    agregar.cuit = tbCuitCuil.Text;
                    agregar.porcentajeRentabilidad = double.Parse(tbRentabilidad.Text);
                    agregar.fechaAlta = System.DateTime.Now;

                    DB.Cliente.Add(agregar);
                    DB.SaveChanges();
                    MessageBox.Show("Cliente agregado correctamente");
                    this.Close();
                }

            }
            else
            {

                using (todoluzdbEntities DB = new todoluzdbEntities())
                {
                    editar.NombreyApellido = tbApellidoyNombre.Text.ToUpper();
                    editar.DNI = tbDNI.Text.ToUpper();
                    editar.direccion = tbDireccion.Text.ToUpper();
                    editar.numeroTelefono = tbTel.Text;
                    editar.email = tbEmail.Text;
                    editar.FechaNac = dtpFechaNac.Value;
                    editar.cuit = tbCuitCuil.Text;
                    editar.porcentajeRentabilidad = double.Parse(tbRentabilidad.Text);

                    DB.Entry(editar).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                    MessageBox.Show("Cliente modificado correctamente");
                    this.Close();
                }
            }

        }

        private void tbRentabilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite un número entero en este campo");

            }
        }
    }
}
