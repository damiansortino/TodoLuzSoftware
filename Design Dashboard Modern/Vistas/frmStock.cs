using Design_Dashboard_Modern.Models;
using System;
using System.Collections.Generic;
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

        private void button3_Click(object sender, EventArgs e)
        {
            panelMovimientosStock.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in panelMovimientosStock.Controls)
            {
                if (item is TextBox || item is MaskedTextBox) { item.Text = ""; }

            }
            panelMovimientosStock.Visible = false;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {

                List<tipoMovimientoStock> tms = DB.tipoMovimientoStock.ToList()
                    .FindAll(x => x.fechaBaja == null);
                List<Producto> listprod = DB.Producto.ToList().FindAll(x => x.FechaBaja == null);

                cboxTipoMovStock.DataSource = tms;
                cboxTipoMovStock.DisplayMember = "nombreTipoMovimientoStock";
                cboxTipoMovStock.ValueMember = "TipoMovimientoStockId";

                cbProducto.DataSource = listprod;
                cbProducto.DisplayMember = "Nombre";
                cbProducto.ValueMember = "Id";
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


        private void button4_Click(object sender, EventArgs e)
        {
            tbCantidad.Text = (int.Parse(tbCantidad.Text) + 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbCantidad.Text = (int.Parse(tbCantidad.Text) - 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                using (todoluzdbEntities DB = new todoluzdbEntities())
                {
                    #region actualizar stock
                    Stock actualizar = new Stock();

                    if (radioButton1.Checked == true)
                    {
                        actualizar.cantidad = int.Parse(tbCantidad.Text) + int.Parse(lblStockActual.Text);
                    }
                    else
                    {
                        actualizar.cantidad = int.Parse(lblStockActual.Text) - int.Parse(tbCantidad.Text);
                    }


                    actualizar.ProductoId = DB.Producto.Find((int)cbProducto.SelectedValue).Id;

                    actualizar.StockId = DB.Stock.ToList().Find(x => x.ProductoId
                    == actualizar.ProductoId).StockId;

                    int cantidadanterior = DB.Stock.ToList().Find(x => x.ProductoId
                    == actualizar.ProductoId).cantidad;

                    DB.Entry(actualizar).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                    #endregion

                    #region crear comprobante

                    comprobante nuevocomprobante = new comprobante();
                    nuevocomprobante.fechaAlta = System.DateTime.Now;
                    //nuevocomprobante.codigo = "32123";
                    nuevocomprobante.TipoComprobanteId = 3;
                    nuevocomprobante.UserId = UsuarioActivo.Id;
                    DB.comprobante.Add(nuevocomprobante);
                    DB.SaveChanges();
                    var comprobanteactual = DB.Set<comprobante>().OrderByDescending(t => t.Id).FirstOrDefault();

                    #endregion

                    #region crear movimiento de stock

                    movimientoStock nuevomovstock = new movimientoStock();
                    if (actualizar.cantidad - cantidadanterior >= 0)
                    {
                        nuevomovstock.cantidad = actualizar.cantidad - cantidadanterior;
                    }
                    else
                    {
                        nuevomovstock.cantidad = -(actualizar.cantidad - cantidadanterior);
                    }
                    nuevomovstock.ComprobanteId = comprobanteactual.Id;
                    nuevomovstock.descripcion = cboxTipoMovStock.Text;
                    nuevomovstock.entra = radioButton1.Checked;
                    nuevomovstock.sale = radioButton2.Checked;
                    nuevomovstock.fechaAlta = nuevocomprobante.fechaAlta;
                    nuevomovstock.StockId = actualizar.StockId;
                    nuevomovstock.TipoMovimientoStockId = (int)cboxTipoMovStock.SelectedItem;
                    nuevomovstock.StockId = actualizar.StockId;
                    DB.movimientoStock.Add(nuevomovstock);
                    DB.SaveChanges();
                    #endregion

                    MessageBox.Show("Stock Actualizado correctamente");

                }
            }
            else
            {
                MessageBox.Show("Compruebe los datos ingresados");
            }


        }

        private bool ValidarCampos()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                if (radioButton1.Checked == true || radioButton2.Checked == true) return true;
                else
                {
                    return false;
                }

            }
        }

        private void tbCantidad_Leave(object sender, EventArgs e)
        {
            if (tbCantidad.TextLength < 1) tbCantidad.Text = "0";
        }

        private void cbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {

                lblStockActual.Text = DB.Stock.ToList().Find(x => x.ProductoId == ((Producto)cbProducto.SelectedItem).Id).cantidad.ToString();

            }

            lblStockActual.Visible = true;
        }
    }
}
