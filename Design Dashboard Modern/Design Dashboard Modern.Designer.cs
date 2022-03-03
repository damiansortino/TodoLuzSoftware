namespace Design_Dashboard_Modern
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.linkCerrarCesion = new System.Windows.Forms.LinkLabel();
            this.lblUsuarioActivo2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.btnConfiguracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCaja = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCtasCtes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVerVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.linkCerrarCesion);
            this.MenuTop.Controls.Add(this.lblUsuarioActivo2);
            this.MenuTop.Controls.Add(this.label3);
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1386, 57);
            this.MenuTop.TabIndex = 0;
            // 
            // linkCerrarCesion
            // 
            this.linkCerrarCesion.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.linkCerrarCesion, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.linkCerrarCesion, BunifuAnimatorNS.DecorationType.None);
            this.linkCerrarCesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCerrarCesion.Location = new System.Drawing.Point(595, 22);
            this.linkCerrarCesion.Name = "linkCerrarCesion";
            this.linkCerrarCesion.Size = new System.Drawing.Size(106, 20);
            this.linkCerrarCesion.TabIndex = 18;
            this.linkCerrarCesion.TabStop = true;
            this.linkCerrarCesion.Text = "Cerrar Sesión";
            this.linkCerrarCesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCerrarCesion_LinkClicked);
            // 
            // lblUsuarioActivo2
            // 
            this.lblUsuarioActivo2.AutoSize = true;
            this.lblUsuarioActivo2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.lblUsuarioActivo2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblUsuarioActivo2, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuarioActivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo2.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActivo2.Location = new System.Drawing.Point(391, 11);
            this.lblUsuarioActivo2.Name = "lblUsuarioActivo2";
            this.lblUsuarioActivo2.Size = new System.Drawing.Size(175, 31);
            this.lblUsuarioActivo2.TabIndex = 19;
            this.lblUsuarioActivo2.Text = "usuarioactivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(166, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Logueado como";
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1312, 12);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1276, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1312, 12);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1348, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÚ";
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(16, 12);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 57);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 731);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.lblTipoUsuario);
            this.Sidebar.Controls.Add(this.lblUsuarioActivo);
            this.Sidebar.Controls.Add(this.btnConfiguracion);
            this.Sidebar.Controls.Add(this.btnStock);
            this.Sidebar.Controls.Add(this.btnCaja);
            this.Sidebar.Controls.Add(this.btnCtasCtes);
            this.Sidebar.Controls.Add(this.btnClientes);
            this.Sidebar.Controls.Add(this.btnVerVentas);
            this.Sidebar.Controls.Add(this.btnVentas);
            this.Sidebar.Controls.Add(this.btnProductos);
            this.Sidebar.Controls.Add(this.btnInicio);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.Red;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.DarkOrange;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.OrangeRed;
            this.Sidebar.GradientTopRight = System.Drawing.Color.Coral;
            this.Sidebar.Location = new System.Drawing.Point(12, 6);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 20;
            this.Sidebar.Size = new System.Drawing.Size(270, 695);
            this.Sidebar.TabIndex = 0;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.lblTipoUsuario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblTipoUsuario, BunifuAnimatorNS.DecorationType.None);
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblTipoUsuario.Location = new System.Drawing.Point(142, 62);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(113, 20);
            this.lblTipoUsuario.TabIndex = 20;
            this.lblTipoUsuario.Text = "tipo de usuario";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.lblUsuarioActivo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.lblUsuarioActivo, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarioActivo.Location = new System.Drawing.Point(66, 42);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(102, 20);
            this.lblUsuarioActivo.TabIndex = 17;
            this.lblUsuarioActivo.Text = "usuarioactivo";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Activecolor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracion.BorderRadius = 0;
            this.btnConfiguracion.ButtonText = "      CONFIGURACION";
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnConfiguracion, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnConfiguracion, BunifuAnimatorNS.DecorationType.None);
            this.btnConfiguracion.DisabledColor = System.Drawing.Color.Gray;
            this.btnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Iconimage")));
            this.btnConfiguracion.Iconimage_right = null;
            this.btnConfiguracion.Iconimage_right_Selected = null;
            this.btnConfiguracion.Iconimage_Selected = null;
            this.btnConfiguracion.IconMarginLeft = 0;
            this.btnConfiguracion.IconMarginRight = 0;
            this.btnConfiguracion.IconRightVisible = true;
            this.btnConfiguracion.IconRightZoom = 0D;
            this.btnConfiguracion.IconVisible = true;
            this.btnConfiguracion.IconZoom = 50D;
            this.btnConfiguracion.IsTab = false;
            this.btnConfiguracion.Location = new System.Drawing.Point(9, 625);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfiguracion.selected = false;
            this.btnConfiguracion.Size = new System.Drawing.Size(252, 58);
            this.btnConfiguracion.TabIndex = 16;
            this.btnConfiguracion.Text = "      CONFIGURACION";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Textcolor = System.Drawing.Color.Black;
            this.btnConfiguracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnStock
            // 
            this.btnStock.Activecolor = System.Drawing.Color.Transparent;
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStock.BorderRadius = 0;
            this.btnStock.ButtonText = "      STOCK";
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnStock, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnStock, BunifuAnimatorNS.DecorationType.None);
            this.btnStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStock.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStock.Iconimage")));
            this.btnStock.Iconimage_right = null;
            this.btnStock.Iconimage_right_Selected = null;
            this.btnStock.Iconimage_Selected = null;
            this.btnStock.IconMarginLeft = 0;
            this.btnStock.IconMarginRight = 0;
            this.btnStock.IconRightVisible = true;
            this.btnStock.IconRightZoom = 0D;
            this.btnStock.IconVisible = true;
            this.btnStock.IconZoom = 50D;
            this.btnStock.IsTab = false;
            this.btnStock.Location = new System.Drawing.Point(9, 568);
            this.btnStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStock.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStock.selected = false;
            this.btnStock.Size = new System.Drawing.Size(252, 58);
            this.btnStock.TabIndex = 15;
            this.btnStock.Text = "      STOCK";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Textcolor = System.Drawing.Color.Black;
            this.btnStock.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.Activecolor = System.Drawing.Color.Transparent;
            this.btnCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaja.BorderRadius = 0;
            this.btnCaja.ButtonText = "      CAJA";
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnCaja, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnCaja, BunifuAnimatorNS.DecorationType.None);
            this.btnCaja.DisabledColor = System.Drawing.Color.Gray;
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCaja.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCaja.Iconimage")));
            this.btnCaja.Iconimage_right = null;
            this.btnCaja.Iconimage_right_Selected = null;
            this.btnCaja.Iconimage_Selected = null;
            this.btnCaja.IconMarginLeft = 0;
            this.btnCaja.IconMarginRight = 0;
            this.btnCaja.IconRightVisible = true;
            this.btnCaja.IconRightZoom = 0D;
            this.btnCaja.IconVisible = true;
            this.btnCaja.IconZoom = 50D;
            this.btnCaja.IsTab = false;
            this.btnCaja.Location = new System.Drawing.Point(9, 511);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCaja.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCaja.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCaja.selected = false;
            this.btnCaja.Size = new System.Drawing.Size(252, 58);
            this.btnCaja.TabIndex = 14;
            this.btnCaja.Text = "      CAJA";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.Textcolor = System.Drawing.Color.Black;
            this.btnCaja.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCtasCtes
            // 
            this.btnCtasCtes.Activecolor = System.Drawing.Color.Transparent;
            this.btnCtasCtes.BackColor = System.Drawing.Color.Transparent;
            this.btnCtasCtes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCtasCtes.BorderRadius = 0;
            this.btnCtasCtes.ButtonText = "      Ctas Ctes.";
            this.btnCtasCtes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnCtasCtes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnCtasCtes, BunifuAnimatorNS.DecorationType.None);
            this.btnCtasCtes.DisabledColor = System.Drawing.Color.Gray;
            this.btnCtasCtes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtasCtes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCtasCtes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCtasCtes.Iconimage")));
            this.btnCtasCtes.Iconimage_right = null;
            this.btnCtasCtes.Iconimage_right_Selected = null;
            this.btnCtasCtes.Iconimage_Selected = null;
            this.btnCtasCtes.IconMarginLeft = 0;
            this.btnCtasCtes.IconMarginRight = 0;
            this.btnCtasCtes.IconRightVisible = true;
            this.btnCtasCtes.IconRightZoom = 0D;
            this.btnCtasCtes.IconVisible = true;
            this.btnCtasCtes.IconZoom = 50D;
            this.btnCtasCtes.IsTab = false;
            this.btnCtasCtes.Location = new System.Drawing.Point(9, 441);
            this.btnCtasCtes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCtasCtes.Name = "btnCtasCtes";
            this.btnCtasCtes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCtasCtes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCtasCtes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCtasCtes.selected = false;
            this.btnCtasCtes.Size = new System.Drawing.Size(252, 58);
            this.btnCtasCtes.TabIndex = 13;
            this.btnCtasCtes.Text = "      Ctas Ctes.";
            this.btnCtasCtes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCtasCtes.Textcolor = System.Drawing.Color.Black;
            this.btnCtasCtes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "      CLIENTES";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 50D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(9, 371);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(252, 58);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Text = "      CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.Black;
            this.btnClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVerVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerVentas.BorderRadius = 0;
            this.btnVerVentas.ButtonText = "      VER VENTAS";
            this.btnVerVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnVerVentas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnVerVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVerVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerVentas.Iconimage")));
            this.btnVerVentas.Iconimage_right = null;
            this.btnVerVentas.Iconimage_right_Selected = null;
            this.btnVerVentas.Iconimage_Selected = null;
            this.btnVerVentas.IconMarginLeft = 0;
            this.btnVerVentas.IconMarginRight = 0;
            this.btnVerVentas.IconRightVisible = true;
            this.btnVerVentas.IconRightZoom = 0D;
            this.btnVerVentas.IconVisible = true;
            this.btnVerVentas.IconZoom = 50D;
            this.btnVerVentas.IsTab = false;
            this.btnVerVentas.Location = new System.Drawing.Point(9, 301);
            this.btnVerVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerVentas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVerVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerVentas.selected = false;
            this.btnVerVentas.Size = new System.Drawing.Size(252, 58);
            this.btnVerVentas.TabIndex = 11;
            this.btnVerVentas.Text = "      VER VENTAS";
            this.btnVerVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerVentas.Textcolor = System.Drawing.Color.Black;
            this.btnVerVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVentas.Click += new System.EventHandler(this.btnVerVentas_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "      NUEVA VENTA";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 50D;
            this.btnVentas.IsTab = false;
            this.btnVentas.Location = new System.Drawing.Point(9, 231);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(252, 58);
            this.btnVentas.TabIndex = 10;
            this.btnVentas.Text = "      NUEVA VENTA";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Textcolor = System.Drawing.Color.Black;
            this.btnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Activecolor = System.Drawing.Color.Transparent;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.BorderRadius = 0;
            this.btnProductos.ButtonText = "      PRODUCTOS";
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnProductos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnProductos, BunifuAnimatorNS.DecorationType.None);
            this.btnProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductos.Iconimage")));
            this.btnProductos.Iconimage_right = null;
            this.btnProductos.Iconimage_right_Selected = null;
            this.btnProductos.Iconimage_Selected = null;
            this.btnProductos.IconMarginLeft = 0;
            this.btnProductos.IconMarginRight = 0;
            this.btnProductos.IconRightVisible = true;
            this.btnProductos.IconRightZoom = 0D;
            this.btnProductos.IconVisible = true;
            this.btnProductos.IconZoom = 50D;
            this.btnProductos.IsTab = false;
            this.btnProductos.Location = new System.Drawing.Point(9, 161);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProductos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnProductos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProductos.selected = false;
            this.btnProductos.Size = new System.Drawing.Size(252, 58);
            this.btnProductos.TabIndex = 9;
            this.btnProductos.Text = "      PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Textcolor = System.Drawing.Color.Black;
            this.btnProductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.Transparent;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "      INICIO";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInicio.Iconimage")));
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 50D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(9, 91);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(252, 58);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "      INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Textcolor = System.Drawing.Color.Black;
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(3, 84);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bienvenido/a";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 57);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1086, 731);
            this.Wrapper.TabIndex = 2;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.AnimacionSidebar.DefaultAnimation = animation1;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCaja;
        private Bunifu.Framework.UI.BunifuFlatButton btnCtasCtes;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductos;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnStock;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfiguracion;
        private System.Windows.Forms.Label lblUsuarioActivo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.LinkLabel linkCerrarCesion;
        private System.Windows.Forms.Label lblTipoUsuario;
    }
}

