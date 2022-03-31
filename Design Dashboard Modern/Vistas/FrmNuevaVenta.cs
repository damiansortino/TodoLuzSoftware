using Design_Dashboard_Modern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class FrmNuevaVenta : Form
    {
        List<Usuario> vendedores = new List<Usuario>();
        List<Cliente> clientes = new List<Cliente>();
        List<Producto> agregados = new List<Producto>();
        comprobante compdeventa = new comprobante();
        List<detalleFactura> detalles = new List<detalleFactura>();
        List<movimientoStock> movimientostock = new List<movimientoStock>();

        bool usuarioespecial = false;


        public FrmNuevaVenta()
        {
            InitializeComponent();
        }

        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                if (CajaAbierta())
                {
                    vendedores = DB.Usuario.ToList().FindAll(x => x.FechaBaja == null);
                    clientes = DB.Cliente.ToList().FindAll(x => x.fechaBaja == null);

                    cboxUsuario.DataSource = vendedores;
                    cboxCliente.DataSource = clientes;

                    cboxUsuario.DisplayMember = "ApellidoyNombre";
                    cboxCliente.DisplayMember = "NombreyApellido";

                }
                else
                {
                    MessageBox.Show("No hay una caja abierta, deberá iniciar una caja para poder realizar la venta");

                    popupAbrirCaja abrircaja = new popupAbrirCaja();
                    abrircaja.ShowDialog();
                    if (CajaAbierta())
                    {
                        vendedores = DB.Usuario.ToList().FindAll(x => x.FechaBaja == null);
                        clientes = DB.Cliente.ToList().FindAll(x => x.fechaBaja == null);

                        cboxUsuario.DataSource = vendedores;
                        cboxCliente.DataSource = clientes;

                        cboxUsuario.DisplayMember = "ApellidoyNombre";
                        cboxCliente.DisplayMember = "NombreyApellido";
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }

        }

        private bool CajaAbierta()
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                List<Caja> abiertas = DB.Caja.ToList().FindAll(x => x.fechaCaja == DateTime.Now.Date && x.fechaCierreCaja == null);
                if (abiertas.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void tbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {


            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                //detecta pulsación de ENTER
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    //no encuentra producto
                    if (DB.Producto.ToList().FindAll(x => x.Codigo == tbcodigo.Text.Trim()).Count < 1)
                    {
                        MessageBox.Show("No existe el producto");
                    }
                    else
                    {
                        //encuentra mas de un producto con el mismo código
                        if (DB.Producto.ToList().FindAll(x => x.Codigo == tbcodigo.Text.Trim()).Count > 1)
                            MessageBox.Show("Existe mas de un producto con este código, busque manualmente su producto");

                        //encuentra un producto único
                        else
                        {
                            detalleFactura nuevodetalle = new detalleFactura();
                            Producto nuevoproducto = new Producto();

                            nuevoproducto = DB.Producto.ToList().Find(x => x.Codigo == tbcodigo.Text.Trim());
                            nuevodetalle.cantidad = 1;
                            nuevodetalle.bonificacion = 0;
                            nuevodetalle.ProductoId = nuevoproducto.Id;

                            //calcula y coloca el precio evaluando si el cliente es especial
                            if (usuarioespecial == true)
                            {
                                nuevodetalle.subtotal = nuevoproducto.PrecioCosto;
                            }
                            else
                            {
                                nuevodetalle.subtotal = nuevoproducto.PrecioCosto
                                    + ((nuevoproducto.PrecioCosto * nuevoproducto.Rentabilidad) / 100);
                            }

                            detalles.Add(nuevodetalle);
                            RefrescarDGV();
                            tbcodigo.Clear();
                            tbcodigo.Focus();

                            tbCantidad.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
                            tbBonificacion.Text = dgvProductos.CurrentRow.Cells[7].Value.ToString();

                            if (detalles.Count > 0)
                            {
                                btnCompletarVenta.Enabled = true;
                                btnImprimirPresupuesto.Enabled = true;
                            }

                        }
                    }
                    e.Handled = true;
                }

            }

        }

        private void RefrescarDGV()
        {

            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                var lst = (from d in detalles
                           join e in DB.Producto.ToList()

                           on d.ProductoId equals e.Id
                           where e.FechaBaja == null

                           select new
                           {
                               Codigo = e.Codigo,
                               Nombre = e.Nombre,
                               Marca = e.Marca,
                               Modelo = e.Modelo,
                               Color = e.Color,
                               Precio = e.PrecioCosto + (e.PrecioCosto * e.Rentabilidad) / 100,
                               Cantidad = d.cantidad,
                               Bonificacion = d.bonificacion,
                               Subtotal = ((e.PrecioCosto + (e.PrecioCosto * e.Rentabilidad) / 100) * (d.cantidad)) - d.bonificacion

                           }).ToList();

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lst;

            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {

                btnOk.Enabled = false;
                detalles[dgvProductos.CurrentRow.Index].cantidad = int.Parse(tbCantidad.Text);
                detalles[dgvProductos.CurrentRow.Index].bonificacion = double.Parse(tbBonificacion.Text);

                double precioprod = DB.Producto.Find(detalles[dgvProductos.CurrentRow.Index].ProductoId).PrecioCosto
                    + (DB.Producto.Find(detalles[dgvProductos.CurrentRow.Index].ProductoId).PrecioCosto
                    * DB.Producto.Find(detalles[dgvProductos.CurrentRow.Index].ProductoId).Rentabilidad) / 100;

                detalles[dgvProductos.CurrentRow.Index].subtotal =
                    (detalles[dgvProductos.CurrentRow.Index].cantidad * precioprod)
                    - double.Parse(detalles[dgvProductos.CurrentRow.Index].bonificacion.ToString());

            }

            RefrescarDGV();
        }

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbCantidad.Text = dgvProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbBonificacion.Text = dgvProductos.Rows[e.RowIndex].Cells[7].Value.ToString();
            btnOk.Enabled = true;
            btnEliminarSeleccionado.Enabled = true;
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            btnEliminarSeleccionado.Enabled = false;
            detalles.RemoveAt(dgvProductos.CurrentRow.Index);
            RefrescarDGV();
            btnOk.Enabled = false;
        }

        private void btnCompletarVenta_Click(object sender, EventArgs e)
        {
            DesactivarFuncionesAgregado();
            RellenarCeros();

            panelFormadePago.Visible = true;

            double suma = 0;
            foreach (detalleFactura item in detalles)
            {
                suma = suma + item.subtotal;
            }

            lblSubtotal.Text = suma.ToString();

            lblTotalGeneral.Text = (double.Parse(lblSubtotal.Text) - double.Parse(tbBonifGeneral.Text)).ToString();
        }

        private void RellenarCeros()
        {
            tbBonifGeneral.Text = "0";
            tbEfectivo.Text = "0";
            tbDebito.Text = "0";
            tbTarjCredito.Text = "0";
            tbCtaCte.Text = "0";

        }

        private void DesactivarFuncionesAgregado()
        {
            btnCompletarVenta.Enabled = false;
            cboxCliente.Enabled = false;
            cboxUsuario.Enabled = false;
            btnEliminarSeleccionado.Enabled = false;
            dgvProductos.Enabled = false;
            btnOk.Enabled = false;
            tbBonificacion.Enabled = false;
            tbCantidad.Enabled = false;
            tbcodigo.Enabled = false;
            btnBuscarProducto.Enabled = false;
        }

        private void tbBonifGeneral_Leave(object sender, EventArgs e)
        {
            if (tbBonifGeneral.TextLength < 1) tbBonifGeneral.Text = "0";
            lblTotalGeneral.Text = (double.Parse(lblSubtotal.Text) - double.Parse(tbBonifGeneral.Text)).ToString();
        }

        private void tbBonifGeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbEfectivo.Focus();
                e.Handled = true;
            }
            else
            {
                int codigo = Convert.ToInt32(e.KeyChar);
                if (codigo == 8) e.Handled = false;
                else
                {
                    if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)) e.Handled = true;
                }
            }
        }

        private void btnAgregarMasProductos_Click(object sender, EventArgs e)
        {
            ReactivarFuncionesAgregado();
            panelFormadePago.Visible = false;
        }

        private void ReactivarFuncionesAgregado()
        {
            btnCompletarVenta.Enabled = true;
            cboxCliente.Enabled = true;
            cboxUsuario.Enabled = true;
            dgvProductos.Enabled = true;
            tbBonificacion.Enabled = true;
            tbCantidad.Enabled = true;
            tbcodigo.Enabled = true;
            btnBuscarProducto.Enabled = true;
        }

        private void btnAceptarVenta_Click(object sender, EventArgs e)
        {

            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                if (ValidarSumas())
                {
                    #region crear comprobante en base de datos

                    compdeventa.bonificacion = double.Parse(tbBonificacion.Text);
                    compdeventa.ClienteId = int.Parse(((Cliente)cboxCliente.SelectedValue).Id.ToString());
                    compdeventa.fechaAlta = System.DateTime.Now;
                    compdeventa.importe = double.Parse(lblTotalGeneral.Text);
                    compdeventa.efectivo = double.Parse(tbEfectivo.Text);
                    compdeventa.CtaCte = double.Parse(tbCtaCte.Text);
                    compdeventa.tarjeta = double.Parse(tbTarjCredito.Text);
                    compdeventa.debito = double.Parse(tbDebito.Text);
                    compdeventa.TipoComprobanteId = 1;
                    compdeventa.UserId = ((Usuario)cboxUsuario.SelectedItem).Id;
                    DB.comprobante.Add(compdeventa);
                    DB.SaveChanges();

                    var registroactualizado = DB.Set<comprobante>().OrderByDescending(t => t.Id).FirstOrDefault();

                    compdeventa.codigo = "XV001-" + registroactualizado.Id.ToString();

                    DB.Entry(compdeventa).State = System.Data.Entity.EntityState.Modified;

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
                        Stock actualizarstock = DB.Stock.ToList().Find(x => x.ProductoId == alpha.ProductoId);
                        actualizarstock.cantidad = actualizarstock.cantidad - alpha.cantidad;
                        DB.Entry(actualizarstock).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                    }



                    #endregion

                    #region Crear movimiento de stock
                    foreach (detalleFactura item in detalles)
                    {
                        movimientoStock movstock = new movimientoStock();
                        movstock.cantidad = item.cantidad;
                        movstock.ComprobanteId = item.ComprobanteId;
                        movstock.descripcion = "Venta";
                        movstock.entra = false;
                        movstock.sale = true;
                        movstock.StockId = DB.Stock.ToList().Find(x => x.ProductoId == item.ProductoId).StockId;
                        movstock.TipoMovimientoStockId = 1;
                        movstock.fechaAlta = registroactualizado.fechaAlta;
                        movimientostock.Add(movstock);
                    }
                    foreach (movimientoStock movi in movimientostock)
                    {
                        DB.movimientoStock.Add(movi);
                        DB.SaveChanges();
                    }
                    #endregion

                    #region Actualizar Caja

                    Caja ultimacaja = DB.Caja.ToList().Find(x => x.fechaCaja == DateTime.Now.Date && (x.fechaCierreCaja == null));
                    ultimacaja.montoCaja = ultimacaja.montoCaja + double.Parse(tbEfectivo.Text);

                    DB.Entry(ultimacaja).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();

                    #endregion

                    #region Crear movimiento de Caja

                    movimientoCaja nuevomovcaja = new movimientoCaja();
                    nuevomovcaja.CajaId = ultimacaja.CajaId;
                    nuevomovcaja.ComprobanteId = registroactualizado.Id;
                    nuevomovcaja.entra = true;
                    nuevomovcaja.sale = false;
                    nuevomovcaja.fechaAlta = registroactualizado.fechaAlta;
                    nuevomovcaja.importe = double.Parse(tbEfectivo.Text);
                    nuevomovcaja.observaciones = "Venta";
                    nuevomovcaja.tipoMovimientoCajaId = 2;
                    DB.movimientoCaja.Add(nuevomovcaja);
                    DB.SaveChanges();

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
            double total, efectivo, tarjeta, ctacte, debito;

            total = double.Parse(lblTotalGeneral.Text);
            efectivo = double.Parse(tbEfectivo.Text);
            tarjeta = double.Parse(tbTarjCredito.Text);
            ctacte = double.Parse(tbCtaCte.Text);
            debito = double.Parse(tbDebito.Text);


            if (total == (efectivo + tarjeta) + (ctacte + debito))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)) e.Handled = true;
        }

        private void tbBonificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)) e.Handled = true;
        }

        private void tbEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (tbEfectivo.TextLength < 1) tbEfectivo.Text = "0";
                tbDebito.Focus();
                e.Handled = true;
            }
            else
            {
                int codigo = Convert.ToInt32(e.KeyChar);
                if (codigo == 8) e.Handled = false;
                else
                {
                    if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)) e.Handled = true;
                }
            }
        }

        private void tbDebito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbTarjCredito.Focus();
                e.Handled = true;
            }
            else
            {
                int codigo = Convert.ToInt32(e.KeyChar);
                if (codigo == 8) e.Handled = false;
                else
                {
                    if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)) e.Handled = true;
                }
            }
        }

        private void tbTarjCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbCtaCte.Focus();
                e.Handled = true;
            }
            else
            {
                int codigo = Convert.ToInt32(e.KeyChar);
                if (codigo == 8) e.Handled = false;
                else
                {
                    if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)) e.Handled = true;
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmProductos buscarprod = new FrmProductos(1);
            buscarprod.ShowDialog();
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            tbcodigo.Text = Clipboard.GetText();
            tbcodigo.Focus();
        }

        private void tbEfectivo_Leave(object sender, EventArgs e)
        {
            if (tbEfectivo.TextLength < 1) tbEfectivo.Text = "0";
        }
    }
}
