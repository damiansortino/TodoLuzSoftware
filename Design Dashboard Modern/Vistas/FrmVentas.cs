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
        AutoCompleteStringCollection nombresproductos = new AutoCompleteStringCollection();
        List<detalleFactura> detalles = new List<detalleFactura>();
        List<Cliente> clientes = new List<Cliente>();
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
                productos = DB.Producto.ToList().FindAll(x => x.FechaBaja == null);

                foreach (Producto item in productos)
                {
                    nombresproductos.Add(item.Nombre);
                }
                foreach (Cliente cli in DB.Cliente)
                {
                    if (cli.fechaBaja == null)
                    {
                        clientes.Add(cli);
                    }
                }

            }

            tbNombreProducto.AutoCompleteCustomSource = nombresproductos;
            tbNombreProducto.Focus();

            cboxCliente.ValueMember = "Id";
            cboxCliente.DisplayMember = "NombreyApellido";
            cboxCliente.DataSource = clientes;
        }

        private void tbNombreProducto_Leave(object sender, EventArgs e)
        {
            if (tbNombreProducto.TextLength != 0)
            {
                tbNombreProducto.Text = tbNombreProducto.Text.ToUpper();

                if (productos.FindAll(x => x.Nombre.ToUpper() == tbNombreProducto.Text.ToUpper()).Count == 1)
                {
                    Producto encontrado = productos.Find(x => x.Nombre == tbNombreProducto.Text.ToUpper());

                    tbCodigo.Text = encontrado.Codigo;
                    tbPrecio.Text = (encontrado.PrecioCosto
                        + (encontrado.PrecioCosto * encontrado.Rentabilidad) / 100).ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }

            }

            tbNombreProducto.Text = tbNombreProducto.Text.ToUpper();
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
                tbNombreProducto.Text = "";
                tbCodigo.Text = "";
                tbCantidad.Text = "1";
                tbDescuentoProducto.Text = "0";
                tbPrecio.Text = "0";
                tbSubtotalProducto.Text = "0";
                RecargarDGV();
                tbNombreProducto.Focus();

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
                tbNombreProducto.Focus();
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
            if ((tbNombreProducto.Text != "" && tbCodigo.TextLength >= 3) && (tbCantidad.Text != ""))
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
                    comprobante comprobante = new comprobante();
                    comprobante.bonificacion = double.Parse(tbDescuentos.Text);
                    comprobante.ClienteId = int.Parse(cboxCliente.SelectedValue.ToString());
                    comprobante.fechaAlta = System.DateTime.Now;
                    comprobante.importe = double.Parse(lblTotalGeneral.Text);
                    comprobante.efectivo = double.Parse(tbEfectivo.Text);
                    comprobante.CtaCte = double.Parse(tbCtaCte.Text);
                    comprobante.tarjeta = double.Parse(tbTarjetas.Text);
                    comprobante.TipoComprobanteId = 1;

                    DB.comprobante.Add(comprobante);
                    DB.SaveChanges();

                    var registroactualizado = DB.Set<comprobante>().OrderByDescending(t => t.Id).FirstOrDefault();

                    comprobante.codigo = "XV001-" + registroactualizado.Id.ToString();

                    DB.Entry(comprobante).State = System.Data.Entity.EntityState.Modified;

                    DB.SaveChanges();

                    MessageBox.Show("Nuevo comprobante creado correctamente");
                }

            }

        }

        private bool ValidarSumas()
        {
            double total, descuento, efectivo, tarjeta, ctacte;

            total = double.Parse(lblTotalGeneral.Text);
            descuento = double.Parse(tbDescuentos.Text);
            efectivo = double.Parse(tbEfectivo.Text);
            tarjeta = double.Parse(tbTarjetas.Text);
            ctacte = double.Parse(tbCtaCte.Text);//ver


            if (total - descuento == (efectivo + tarjeta) + ctacte)
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
                    Producto encontrado = productos.Find(x => x.Codigo.ToUpper() == tbCodigo.Text.Trim().ToUpper());

                    tbNombreProducto.Text = encontrado.Nombre;
                    tbPrecio.Text = (encontrado.PrecioCosto
                        + (encontrado.PrecioCosto * encontrado.Rentabilidad) / 100).ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }

            }

            tbNombreProducto.Text = tbNombreProducto.Text.ToUpper();
        }

        private void tbCtaCte_Leave(object sender, EventArgs e)
        {
            if (tbCtaCte.Text == "" || tbCtaCte.Text == null) tbCtaCte.Text = "0";
        }
    }
}
