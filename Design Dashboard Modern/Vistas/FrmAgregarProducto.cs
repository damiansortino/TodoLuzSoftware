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
                tbStockInicial.Text = db.Stock.ToList().Find(x => x.ProductoId == id).cantidad.ToString();
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
            if (tbStockInicial.TextLength < 1) tbStockInicial.Text = "0";

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


                        if (cbTieneCodigoBarra.Checked)
                        {
                            oproducto.Codigo = tbCódigo.Text;
                            db.Producto.Add(oproducto);
                            db.SaveChanges();

                            var registroMasActualizado = db.Set<Producto>().OrderByDescending(t => t.Id).FirstOrDefault();

                            //crear el stock

                            Stock stockproducto = new Stock();
                            stockproducto.cantidad = int.Parse(tbStockInicial.Text);
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

                            //crea el stock
                            Stock stockproducto = new Stock();
                            stockproducto.cantidad = int.Parse(tbStockInicial.Text);
                            stockproducto.ProductoId = registroMasActualizado.Id;
                            db.Stock.Add(stockproducto);
                            db.SaveChanges();

                            MessageBox.Show("Producto Agregado Correctamente");
                            this.Close();
                        }

                    }
                    else
                    {
                        Producto modif = db.Producto.Find(id);


                        modif.Nombre = tbNombre.Text.ToUpper();
                        modif.Descripcion = tbDescripción.Text.ToUpper();
                        modif.Marca = tbMarca.Text.ToUpper();
                        modif.Modelo = tbModelo.Text.ToUpper();
                        modif.Color = tbColor.Text.ToUpper();
                        modif.Rentabilidad = double.Parse(tbRentabilidad.Text);
                        modif.PrecioCosto = double.Parse(tbPreciodeCosto.Text);

                        if (cbTieneCodigoBarra.Checked)
                        {
                            modif.Codigo = tbCódigo.Text;
                            db.Entry(modif).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                        else
                        {
                            modif.Codigo = modif.Id.ToString();
                            db.Entry(modif).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }

                        Stock stockproducto = db.Stock.ToList().Find(x => x.ProductoId == id);
                        stockproducto.cantidad = int.Parse(tbStockInicial.Text);
                        stockproducto.ProductoId = (int)id;
                        db.Entry(stockproducto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        MessageBox.Show("Producto modificado Correctamente");
                        this.Close();
                    }

                }

            }

        }
        #endregion

        private void tbCódigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbStockInicial.Focus();
                e.Handled = true;
            }
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            tbNombre.Focus();
        }
    }
}
