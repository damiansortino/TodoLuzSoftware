using Design_Dashboard_Modern.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Vistas
{
    public partial class FrmAgregarProducto : Form
    {
        public int? id;
        Producto oproducto = null;
        public FrmAgregarProducto(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            using (todoluzdbEntities db = new todoluzdbEntities())
            {
                oproducto = db.Producto.Find(id);
                tbMarca.Text = oproducto.Marca;
                tbDescripción.Text = oproducto.Descripcion;
                tbColor.Text = oproducto.Color;
                tbModelo.Text = oproducto.Modelo;
                tbNombre.Text = oproducto.Nombre;
                tbPreciodeCosto.Text = oproducto.PrecioCosto.ToString();
                tbRentabilidad.Text = oproducto.Rentabilidad.ToString();
                tbCódigo.Text = oproducto.Codigo;


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void cbTieneCodigoBarra_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbTieneCodigoBarra.CheckState == CheckState.Checked)
            {
                tbCódigo.Visible = true;
                label7.Visible = true;
            }
            else
            {
                tbCódigo.Visible = false;
                label7.Visible = false;
                tbCódigo.Text = null;
            }
        }

        #region Metodos
        private void AgregarProducto()
        {
            using (todoluzdbEntities db = new todoluzdbEntities())
            {
                if (((tbNombre.TextLength < 4) || (tbRentabilidad == null)) || (double.Parse(tbPreciodeCosto.Text) == 0))
                {
                    MessageBox.Show("Debe completar los campos obligatorios para poder agregar o modificar su producto");
                }
                else
                {
                    //evalua si es nuevo o modificación

                    if (id == null)
                    {
                        Producto oproducto = new Producto();
                        oproducto.Nombre = tbNombre.Text.ToUpper();
                        oproducto.Descripcion = tbDescripción.Text.ToUpper();
                        oproducto.Marca = tbMarca.Text.ToUpper();
                        oproducto.Modelo = tbModelo.Text.ToUpper();
                        oproducto.Color = tbColor.Text.ToUpper();
                        oproducto.Rentabilidad = double.Parse(tbRentabilidad.Text);
                        oproducto.PrecioCosto = double.Parse(tbPreciodeCosto.Text);
                        oproducto.FechaAlta = DateTime.Now;

                        //se comprueba si tiene codigo de barras y se confirma la operacion de agregado

                        if (cbTieneCodigoBarra.Checked)
                        {
                            oproducto.Codigo = tbCódigo.Text;
                            db.Producto.Add(oproducto);
                            db.SaveChanges();

                            var registroMasActualizado = db.Set<Producto>().OrderByDescending(t => t.Id).FirstOrDefault();

                            Stock stockproducto = new Stock();
                            stockproducto.cantidad = 0;
                            stockproducto.ProductoId = registroMasActualizado.Id;
                            db.Stock.Add(stockproducto);
                            db.SaveChanges();
                            MessageBox.Show("Producto Agregado Correctamente");
                            this.Close();
                        }
                        else
                        {
                            oproducto.Codigo = "";
                            db.Producto.Add(oproducto);
                            db.SaveChanges();

                            var registroMasActualizado = db.Set<Producto>().OrderByDescending(t => t.Id).FirstOrDefault();
                            oproducto.Codigo = registroMasActualizado.Id.ToString();

                            db.Entry(oproducto).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            Stock stockproducto = new Stock();
                            stockproducto.cantidad = 0;
                            stockproducto.ProductoId = registroMasActualizado.Id;
                            db.Stock.Add(stockproducto);
                            db.SaveChanges();

                            MessageBox.Show("Producto Agregado Correctamente");
                            this.Close();
                        }
                    }
                    else
                    {

                        oproducto.Nombre = tbNombre.Text.ToUpper();
                        oproducto.Descripcion = tbDescripción.Text.ToUpper();
                        oproducto.Marca = tbMarca.Text.ToUpper();
                        oproducto.Modelo = tbModelo.Text.ToUpper();
                        oproducto.Color = tbColor.Text.ToUpper();
                        oproducto.Rentabilidad = double.Parse(tbRentabilidad.Text);
                        oproducto.PrecioCosto = double.Parse(tbPreciodeCosto.Text);
                        if (tbCódigo.Text != null) oproducto.Codigo = tbCódigo.Text;

                        db.Entry(oproducto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Producto modificado Correctamente");
                        this.Close();
                    }

                }

            }

        }
        #endregion
    }
}
