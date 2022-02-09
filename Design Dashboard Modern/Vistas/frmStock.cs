using Design_Dashboard_Modern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Design_Dashboard_Modern.Models;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelMovimientosStock.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in panelMovimientosStock.Controls)
            {
                if(item is TextBox || item is MaskedTextBox) { item.Text = ""; }

            }
            panelMovimientosStock.Visible = false;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                List<string> autocompletadotipomovstock = new List<string>();

                foreach (tipoMovimientoStock itemstock in DB.tipoMovimientoStock.ToList())
                {
                    if (itemstock.fechaBaja == null) autocompletadotipomovstock.Add(itemstock.nombreTipoMovimientoStock);
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
                    List<Producto> productosfiltrados = DB.Producto.ToList().FindAll(x => x.Codigo.Contains(tbFiltro.Text.Trim()));

                    if (productosfiltrados.Count < 1)
                    {
                        MessageBox.Show("No se encontró el producto para ver su stock");
                    }
                    else
                    {
                        dgvMuestraStock.DataSource = DB.Stock.ToList().FindAll(x => x.ProductoId == productosfiltrados[0].Id);
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

        private void cboxTipoMovStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedtbCantidad.Text = (int.Parse(maskedtbCantidad.Text) + 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedtbCantidad.Text = (int.Parse(maskedtbCantidad.Text) -1).ToString();
        }

        private void tbCodigoProductoMovStock_Leave(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                maskedtbCantidad.Text = DB.Stock.ToList().Find(x => x.ProductoId
                == DB.Producto.ToList().Find(y => y.Codigo == tbCodigoProductoMovStock.Text.Trim())
                .Id).cantidad.ToString();

            }
        }

        private void tbCodigoProductoMovStock_Enter(object sender, EventArgs e)
        {
            tbCodigoProductoMovStock.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                # region actualizar stock
                Stock actualizar = new Stock();
                actualizar.cantidad = int.Parse(maskedtbCantidad.Text);
                
                actualizar.ProductoId = DB.Producto.ToList().Find(y => 
                y.Codigo == tbCodigoProductoMovStock.Text.Trim()).Id;

                actualizar.StockId = DB.Stock.ToList().Find(x=>x.ProductoId
                == actualizar.ProductoId).StockId;

                int cantidadanterior = DB.Stock.ToList().Find(x => x.ProductoId
                == actualizar.ProductoId).cantidad;

                DB.Entry(actualizar).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                #endregion

                #region crear comprobante
                /*
                comprobante nuevocomprobante = new comprobante();
                nuevocomprobante.fechaAlta = System.DateTime.Now;
                //nuevocomprobante.codigo = "32123";
                nuevocomprobante.TipoComprobanteId = 3;
                nuevocomprobante.
                */

                #endregion

                #region crear movimiento de stock

                movimientoStock nuevomovstock = new movimientoStock();
                if(actualizar.cantidad - cantidadanterior >= 0)
                {
                    nuevomovstock.cantidad = actualizar.cantidad - cantidadanterior;
                }
                else
                {
                    nuevomovstock.cantidad = -(actualizar.cantidad - cantidadanterior);
                }

                #endregion



                //nuevomovstock.ComprobanteId = null;

                MessageBox.Show("Stock Actualizado correctamente");

            }
        }
    }
}
