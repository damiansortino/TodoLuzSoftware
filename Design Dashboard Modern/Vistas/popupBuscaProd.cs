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

namespace Design_Dashboard_Modern.Vistas
{
    public partial class popupBuscaProd : Form
    {
        public popupBuscaProd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupBuscaProd_Load(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                cboxProductos.DataSource = DB.Producto.ToList().FindAll(x => x.FechaBaja == null);
                cboxProductos.ValueMember = "Nombre";
            }
        }

        private void btnVerCodigo_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = ((Producto)cboxProductos.SelectedItem).Codigo;
            tbCodigo.Visible = true;
            btnCopiar.Visible = true;
        }

        private void cboxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCopiar.Visible = false;
            tbCodigo.Visible = false;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbCodigo.Text);
        }
    }
}
