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
        bool usuarioespecial = false;


        public FrmNuevaVenta()
        {
            InitializeComponent();
        }

        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                vendedores = DB.Usuario.ToList().FindAll(x => x.FechaBaja == null);
                clientes = DB.Cliente.ToList().FindAll(x => x.fechaBaja == null);

                cboxUsuario.DataSource = vendedores;
                cboxCliente.DataSource = clientes;

                cboxUsuario.DisplayMember = "ApellidoyNombre";
                cboxCliente.DisplayMember = "NombreyApellido";


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
                               Subtotal = ((e.PrecioCosto + (e.PrecioCosto * e.Rentabilidad) / 100)*(d.cantidad))-d.bonificacion
                               
                           }).ToList();

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lst;

            }


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            detalles[dgvProductos.CurrentRow.Index].cantidad = int.Parse(tbCantidad.Text);
            detalles[dgvProductos.CurrentRow.Index].bonificacion = double.Parse(tbBonificacion.Text);
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
            lblTotalGeneral.Text = (double.Parse(lblSubtotal.Text)-double.Parse(tbBonifGeneral.Text)).ToString();
        }

        private void tbBonifGeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbEfectivo.Focus();
                e.Handled = true;
            }
            else
            {
                if ((char.IsLetter(e.KeyChar)) && (e.KeyChar == (char)Keys.Back)) e.Handled = true;
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

            //trabajar en esto mañana


            /*
            
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
            


            */

        }
    }
}
