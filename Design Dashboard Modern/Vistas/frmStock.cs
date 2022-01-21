using Design_Dashboard_Modern.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelMovimientosStock.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMovimientosStock.Visible = false;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                List<string> autocompletadotipomovstock = new List<string>();

                foreach (tipoMovimientoStock itemstock in DB.tipoMovimientoStock.ToList())
                {
                    autocompletadotipomovstock.Add(itemstock.nombreTipoMovimientoStock);
                }
                cboxTipoMovStock.DataSource = autocompletadotipomovstock;

            }
        }

        private void btnStockxProducto_Click(object sender, EventArgs e)
        {
            if (tbFiltro.TextLength >= 4)
            {
                using (todoluzdbEntities DB = new todoluzdbEntities())
                {
                    List<Producto> productosfiltrados = DB.Producto.ToList().FindAll(x=>x.Codigo.Contains(tbFiltro.Text.Trim()));

                    if (productosfiltrados.Count < 1)
                    {
                        MessageBox.Show("No se encontró el producto para ver su stock");
                    }
                    else
                    {
                        dgvMuestraStock.DataSource = DB.Stock.ToList().FindAll(x=>x.ProductoId == productosfiltrados[0].Id);
                    }
                }

            }
            else
            {
                MessageBox.Show("El código de producto debe tener al menos 4 caracteres.");
            }

        }

        private void tbFiltro_Enter(object sender, EventArgs e)
        {
            tbFiltro.Text = "";
        }
    }
}
