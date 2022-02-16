using Design_Dashboard_Modern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{

    public partial class FrmVentas : Form
    {
        List<Producto> productos = new List<Producto>();
        List<detalleFactura> detalles = new List<detalleFactura>();
        List<Cliente> clientes = new List<Cliente>();
        Cliente clisel = new Cliente();

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            tbDescuentoProducto.Text = "0";
            tbCantidad.Text = "1";

            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                clientes = DB.Cliente.ToList().FindAll(x => x.fechaBaja == null);
                productos = DB.Producto.ToList().FindAll(x => x.FechaBaja == null);
                cbNombreProducto.DataSource = productos;
                cbNombreProducto.DisplayMember = "Nombre";
                cbNombreProducto.ValueMember = "Id";

                cboxCliente.ValueMember = "Id";
                cboxCliente.DisplayMember = "NombreyApellido";
                cboxCliente.DataSource = clientes;
            }
        }


            private void tbCantidad_Leave(object sender, EventArgs e)
            {
                if (tbPrecio.Text != "" && tbCantidad.Text != "")
                {
                    tbSubtotalProducto.Text = ((double.Parse(tbPrecio.Text)
                        * double.Parse(tbCantidad.Text)) - double.Parse(tbDescuentoProducto.Text)).ToString();
                }
            }
            private void btnAgregar_Click(object sender, EventArgs e)
            {
                if (ComprobarCampos())
                {
                    Producto prod = new Producto();

                    using (todoluzdbEntities DB = new todoluzdbEntities())
                    {
                        prod = DB.Producto.ToList().Find(x => x.Codigo == tbCodigo.Text);
                    }
                    detalleFactura agregar = new detalleFactura();
                    agregar.bonificacion = double.Parse(tbDescuentoProducto.Text);
                    agregar.cantidad = int.Parse(tbCantidad.Text);
                    agregar.subtotal = double.Parse(tbSubtotalProducto.Text);
                    agregar.ProductoId = prod.Id;

                    detalles.Add(agregar);
                    tbCodigo.Text = "";
                    tbCantidad.Text = "1";
                    tbDescuentoProducto.Text = "0";
                    tbPrecio.Text = "0";
                    tbSubtotalProducto.Text = "0";
                    RecargarDGV();

                    //actualizar el subtotal general
                    double stg = 0;
                    foreach (DataGridViewRow item in dgvMuestraDetallesProductos.Rows)
                    {
                        stg = stg + double.Parse(item.Cells[2].Value.ToString());
                    }
                    lblSubtotalGeneral.Text = stg.ToString();
                    //fin

                }
                else
                {
                    MessageBox.Show("debe completar los campos primero");
                }

                //activa boton medio de pago y quitar producto, desactiva cb cliente
                if (dgvMuestraDetallesProductos.Rows.Count > 0)
                {
                    btnMediosDePago.Visible = true;
                    btnQuitarProducto.Visible = true;
                    cboxCliente.Enabled = false;
                }


                //fin

            }
            private void RecargarDGV()
            {
                dgvMuestraDetallesProductos.Visible = true;
                dgvMuestraDetallesProductos.DataSource = null;
                dgvMuestraDetallesProductos.DataSource = detalles;
            }

            private void tbDescuentoProducto_Leave(object sender, EventArgs e)
            {
                if (ComprobarCampos())
                {
                    tbSubtotalProducto.Text = ((double.Parse(tbPrecio.Text)
                    * double.Parse(tbCantidad.Text))
                    - double.Parse(tbDescuentoProducto.Text)).ToString();
                }
            }
            private bool ComprobarCampos()
            {
                if ((tbCodigo.TextLength >= 3))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private void tbNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    tbCantidad.Focus();
                }
            }

            private void btnMediosDePago_Click(object sender, EventArgs e)
            {
                panMediosDePago.Visible = true;
                lblTotalGeneral.Text = lblSubtotalGeneral.Text;
                tbEfectivo.Text = "0";
                tbTarjetas.Text = "0";
                tbDescuentos.Text = "0";
                tbCtaCte.Text = "0";
                btnImprimirPresupuesto.Enabled = true;

            }

            private void btnQuitarProducto_Click(object sender, EventArgs e)
            {
                detalles = detalles.FindAll(x => x.ProductoId != (int)dgvMuestraDetallesProductos.Rows[dgvMuestraDetallesProductos.CurrentRow.Index].Cells[6].Value);
            }

            private void dgvMuestraDetallesProductos_MouseClick(object sender, MouseEventArgs e)
            {
                if (dgvMuestraDetallesProductos.SelectedRows.Count > 0)
                {
                    btnQuitarProducto.Enabled = true;
                }
            }

            private void tbDescuentos_Leave(object sender, EventArgs e)
            {
                //protejer textbox vacio
                if (tbDescuentos.TextLength < 1) tbDescuentos.Text = "0";


                lblTotalGeneral.Text = (double.Parse(lblSubtotalGeneral.Text)
                    - double.Parse(tbDescuentos.Text)).ToString();
            }

            private void tbEfectivo_Leave(object sender, EventArgs e)
            {
                //protejer textbox vacio
                if (tbEfectivo.TextLength < 1) tbEfectivo.Text = "0";

                double resto, efectivo, tarjetas = 0;
                efectivo = double.Parse(tbEfectivo.Text);
                tarjetas = double.Parse(tbTarjetas.Text);
                resto = double.Parse(lblTotalGeneral.Text) - (efectivo + tarjetas);
                lblRestoPorPagar.Text = "Restan $ " + resto + " por pagar.";
                lblRestoPorPagar.Visible = true;
                if (resto == 0)
                {
                    lblRestoPorPagar.Visible = false;
                    btnAceptarVenta.Enabled = true;
                }
            }

            private void tbTarjetas_Leave(object sender, EventArgs e)
            {
                //protejer textbox vacio
                if (tbTarjetas.TextLength < 1) tbTarjetas.Text = "0";

                double resto, efectivo, tarjetas = 0;
                efectivo = double.Parse(tbEfectivo.Text);
                tarjetas = double.Parse(tbTarjetas.Text);
                resto = double.Parse(lblTotalGeneral.Text) - (efectivo + tarjetas);
                lblRestoPorPagar.Text = "Restan $ " + resto + " por pagar.";
                lblRestoPorPagar.Visible = true;
                if (resto == 0)
                {
                    lblRestoPorPagar.Visible = false;
                    btnAceptarVenta.Enabled = true;
                }
            }

            private void btnAceptarVenta_Click(object sender, EventArgs e)
            {
                btnAceptarVenta.Enabled = false;

                using (todoluzdbEntities DB = new todoluzdbEntities())
                {
                    if (ValidarSumas())
                    {
                        #region crear comprobante en base de datos
                        comprobante comprobante = new comprobante();
                        comprobante.bonificacion = double.Parse(tbDescuentos.Text);
                        comprobante.ClienteId = int.Parse(cboxCliente.SelectedValue.ToString());
                        comprobante.fechaAlta = System.DateTime.Now;
                        comprobante.importe = double.Parse(lblTotalGeneral.Text);
                        comprobante.efectivo = double.Parse(tbEfectivo.Text);
                        comprobante.CtaCte = double.Parse(tbCtaCte.Text);
                        comprobante.tarjeta = double.Parse(tbTarjetas.Text);
                        comprobante.TipoComprobanteId = 1;
                        comprobante.UserId = UsuarioActivo.Id;
                        DB.comprobante.Add(comprobante);
                        DB.SaveChanges();

                        var registroactualizado = DB.Set<comprobante>().OrderByDescending(t => t.Id).FirstOrDefault();

                        comprobante.codigo = "XV001-" + registroactualizado.Id.ToString();

                        DB.Entry(comprobante).State = System.Data.Entity.EntityState.Modified;

                        DB.SaveChanges();
                        #endregion

                        #region Guardar detalles en base de datos
                        foreach (detalleFactura det in detalles)
                        {
                            det.ComprobanteId = registroactualizado.Id;
                            det.fechaAlta = registroactualizado.fechaAlta;
                            DB.detalleFactura.Add(det);
                            DB.SaveChanges();
                        }
                        #endregion

                        #region Actualizar stock
                        foreach (detalleFactura alpha in detalles)
                        {
                            if (DB.Stock.ToList().FindAll(x => x.ProductoId == alpha.ProductoId).Count > 0)
                            {

                            }

                        }



                        #endregion

                        #region Crear movimiento de stock




                        #endregion

                        #region Actualizar Caja




                        #endregion

                        #region Crear movimiento de Caja

                        #endregion

                        MessageBox.Show("Venta Cargada Correctamente");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Revise el/los medios de pago");
                    }

                }

            }

            private bool ValidarSumas()
            {
                double total, efectivo, tarjeta, ctacte;

                total = double.Parse(lblTotalGeneral.Text);
                efectivo = double.Parse(tbEfectivo.Text);
                tarjeta = double.Parse(tbTarjetas.Text);
                ctacte = double.Parse(tbCtaCte.Text);


                if (total == (efectivo + tarjeta) + ctacte)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            private void tbCodigo_Leave(object sender, EventArgs e)
            {
                if (tbCodigo.TextLength != 0)
                {
                    if (productos.Contains(productos.Find(x => x.Codigo.ToUpper() == tbCodigo.Text.Trim().ToUpper())))
                    {
                    CompletarPorCodigo();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                    }
                }
            }

        private void CompletarPorCodigo()
        {
            Producto sel = productos.Find(x => x.Codigo == tbCodigo.Text.Trim().ToUpper());

            if (clisel.porcentajeRentabilidad != null) tbPrecio.Text = 
                    (sel.PrecioCosto + (sel.PrecioCosto * clisel.porcentajeRentabilidad) / 100).ToString();
            else
            {
                tbPrecio.Text = (sel.PrecioCosto + (sel.PrecioCosto * sel.Rentabilidad) / 100).ToString();
            }

            cbNombreProducto.SelectedItem = sel.Id;
        }

        private void tbCtaCte_Leave(object sender, EventArgs e)
            {
                if (tbCtaCte.Text == "" || tbCtaCte.Text == null) tbCtaCte.Text = "0";
            }

        private void cbNombreProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SeleccionarPorNombre();
        }

        private void SeleccionarPorNombre()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                
                Producto seleccionado = DB.Producto.Find((int)cbNombreProducto.SelectedValue);
                tbCodigo.Text = seleccionado.Codigo;

                if (clisel.porcentajeRentabilidad != null) tbPrecio.Text = (seleccionado.PrecioCosto
                        + ((seleccionado.PrecioCosto * clisel.porcentajeRentabilidad) / 100)).ToString();
                else
                {
                    tbPrecio.Text = (seleccionado.PrecioCosto
                        + ((seleccionado.PrecioCosto * seleccionado.Rentabilidad) / 100)).ToString();
                }
            }
            
        }
    }
    }
