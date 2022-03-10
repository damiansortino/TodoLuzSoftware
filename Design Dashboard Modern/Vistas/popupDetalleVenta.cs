using Design_Dashboard_Modern.Models;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class popupDetalleVenta : Form
    {
        int compr = 0;
        public popupDetalleVenta()
        {
            InitializeComponent();
        }

        public popupDetalleVenta(int v)
        {
            compr = v;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void popupDetalleVenta_Load(object sender, System.EventArgs e)
        {
            comprobante doc = new comprobante();
            string nombrecliente, nombrevendedor;


            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                doc = DB.comprobante.Find(compr);
                nombrecliente = DB.Cliente.Find(doc.ClienteId).NombreyApellido;
                nombrevendedor = DB.Usuario.Find(doc.UserId).ApellidoyNombre;

            }

            lblFecha.Text = doc.fechaAlta.ToString();
            lblComprobante.Text = doc.codigo;
            lblCliente.Text = nombrecliente;
            lblVendedor.Text = nombrevendedor;


        }
    }
}
