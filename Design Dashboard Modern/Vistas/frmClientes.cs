using Design_Dashboard_Modern.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente nuevocliente = new frmAgregarCliente();
            nuevocliente.ShowDialog();
            Refrescar();
        }
        private void Refrescar()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                dgvMuestraClientes.DataSource = DB.Cliente.ToList().FindAll(x => x.fechaBaja == null);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                Cliente editar = (Cliente)dgvMuestraClientes.CurrentRow.DataBoundItem;

                frmAgregarCliente editarcliente = new frmAgregarCliente(editar.Id);
                editarcliente.ShowDialog();
                Refrescar();

            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                Cliente eliminar = (Cliente)dgvMuestraClientes.CurrentRow.DataBoundItem;
                eliminar.fechaBaja = DateTime.Now;
                DB.Entry(eliminar).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                MessageBox.Show("Cliente eliminado Correctamente");
                Refrescar();
            }
        }
    }
}
