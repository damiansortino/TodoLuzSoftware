using Design_Dashboard_Modern.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Design_Dashboard_Modern.Vistas
{
    public partial class popupCierredeCaja : Form
    {
        Caja abierta = new Caja();
        public popupCierredeCaja()
        {
            InitializeComponent();
        }

        private void popupCierredeCaja_Load(object sender, EventArgs e)
        {
            using (todoluzdbEntities DB = new todoluzdbEntities())
            {
                abierta = DB.Set<Caja>().OrderByDescending(t => t.CajaId).FirstOrDefault();
                lblMontoCierre.Text = abierta.montoCaja.ToString();
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                using (todoluzdbEntities DB = new todoluzdbEntities())
                {
                    string msj = "Está cerrando la caja con un ";
                    string faltantesobrante = "";
                    string importedif = "";

                    if (double.Parse(tbImporte.Text) > double.Parse(lblMontoCierre.Text))
                    {
                        faltantesobrante = "sobrante de: ";
                        importedif = (double.Parse(tbImporte.Text) - double.Parse(lblMontoCierre.Text)).ToString();
                    }
                    else
                    {
                        if (double.Parse(tbImporte.Text) < double.Parse(lblMontoCierre.Text))
                        {
                            faltantesobrante = "faltante de: ";
                            importedif = (double.Parse(lblMontoCierre.Text) - double.Parse(tbImporte.Text)).ToString();
                        }
                        else
                        {
                            msj = "El cierre de caja es correcto";
                        }
                    }

                    MessageBox.Show(msj + faltantesobrante + importedif);

                    abierta.fechaCierreCaja = DateTime.Now;
                    abierta.montoCaja = double.Parse(tbImporte.Text);
                    DB.Entry(abierta).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();

                    movimientoCaja movcaja = new movimientoCaja();
                    
                    movcaja.CajaId = abierta.CajaId;
                    movcaja.fechaAlta = DateTime.Now;
                    movcaja.observaciones = "Cierre de Caja";
                    movcaja.tipoMovimientoCajaId = 3;
                                        
                    if(faltantesobrante == "sobrante de: ")
                    {
                        movcaja.importe = double.Parse(importedif);
                        movcaja.entra = true;
                        movcaja.sale = false;
                    }
                    else
                    {
                        if(faltantesobrante == "faltante de: ")
                        {
                            movcaja.importe = double.Parse(importedif);
                            movcaja.sale = true;
                            movcaja.entra = false;
                        }
                        else
                        {
                            movcaja.importe = 0;
                            movcaja.sale = false;
                            movcaja.entra = true;
                        }
                    }

                    DB.movimientoCaja.Add(movcaja);
                    DB.SaveChanges();
                }
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error intentando cerrar la caja");
            }

        }
    }
}
