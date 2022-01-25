using Design_Dashboard_Modern.Vistas;
using System;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmProductos());
        }

        private void AbrirFormHijo(Object formhijo)
        {
            if (this.Wrapper.Controls.Count > 0) this.Wrapper.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Wrapper.Controls.Add(fh);
            this.Wrapper.Tag = fh;
            fh.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock formstock = new frmStock();
            AbrirFormHijo(formstock);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmConfiguracion configuracion = new frmConfiguracion();
            AbrirFormHijo(configuracion);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas formventas = new FrmVentas();
            AbrirFormHijo(formventas);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes formclientes = new frmClientes();
            AbrirFormHijo(formclientes);
        }
    }
}
