
namespace Design_Dashboard_Modern.Vistas
{
    partial class FrmNuevaVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cboxUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBonificacion = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCompletarVenta = new System.Windows.Forms.Button();
            this.btnImprimirPresupuesto = new System.Windows.Forms.Button();
            this.tbBonifGeneral = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEfectivo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDebito = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbTarjCredito = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCtaCte = new System.Windows.Forms.TextBox();
            this.panelFormadePago = new System.Windows.Forms.Panel();
            this.btnAceptarVenta = new System.Windows.Forms.Button();
            this.btnAgregarMasProductos = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnPegar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelFormadePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "código del producto";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcodigo.Location = new System.Drawing.Point(178, 147);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(523, 26);
            this.tbcodigo.TabIndex = 2;
            this.tbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcodigo_KeyPress);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(178, 109);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(162, 32);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "buscar producto...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(717, 260);
            this.dgvProductos.TabIndex = 4;
            this.dgvProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseClick);
            // 
            // cboxUsuario
            // 
            this.cboxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUsuario.FormattingEnabled = true;
            this.cboxUsuario.Location = new System.Drawing.Point(108, 8);
            this.cboxUsuario.Name = "cboxUsuario";
            this.cboxUsuario.Size = new System.Drawing.Size(219, 28);
            this.cboxUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cliente";
            // 
            // cboxCliente
            // 
            this.cboxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(108, 45);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(219, 28);
            this.cboxCliente.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Location = new System.Drawing.Point(9, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 260);
            this.panel1.TabIndex = 9;
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(749, 249);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(175, 32);
            this.btnEliminarSeleccionado.TabIndex = 11;
            this.btnEliminarSeleccionado.Text = "Eliminar Seleccionado";
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(862, 147);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(41, 26);
            this.tbCantidad.TabIndex = 12;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(775, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(749, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bonificacion";
            // 
            // tbBonificacion
            // 
            this.tbBonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBonificacion.Location = new System.Drawing.Point(862, 178);
            this.tbBonificacion.Name = "tbBonificacion";
            this.tbBonificacion.Size = new System.Drawing.Size(121, 26);
            this.tbBonificacion.TabIndex = 14;
            this.tbBonificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBonificacion_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(861, 210);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(42, 32);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCompletarVenta
            // 
            this.btnCompletarVenta.Enabled = false;
            this.btnCompletarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletarVenta.Location = new System.Drawing.Point(732, 360);
            this.btnCompletarVenta.Name = "btnCompletarVenta";
            this.btnCompletarVenta.Size = new System.Drawing.Size(296, 32);
            this.btnCompletarVenta.TabIndex = 18;
            this.btnCompletarVenta.Text = "Completar Venta";
            this.btnCompletarVenta.UseVisualStyleBackColor = true;
            this.btnCompletarVenta.Click += new System.EventHandler(this.btnCompletarVenta_Click);
            // 
            // btnImprimirPresupuesto
            // 
            this.btnImprimirPresupuesto.Enabled = false;
            this.btnImprimirPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirPresupuesto.Location = new System.Drawing.Point(732, 410);
            this.btnImprimirPresupuesto.Name = "btnImprimirPresupuesto";
            this.btnImprimirPresupuesto.Size = new System.Drawing.Size(296, 32);
            this.btnImprimirPresupuesto.TabIndex = 19;
            this.btnImprimirPresupuesto.Text = "Imprimir Presupuesto";
            this.btnImprimirPresupuesto.UseVisualStyleBackColor = true;
            // 
            // tbBonifGeneral
            // 
            this.tbBonifGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBonifGeneral.Location = new System.Drawing.Point(174, 39);
            this.tbBonifGeneral.Name = "tbBonifGeneral";
            this.tbBonifGeneral.Size = new System.Drawing.Size(87, 26);
            this.tbBonifGeneral.TabIndex = 21;
            this.tbBonifGeneral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBonifGeneral_KeyPress);
            this.tbBonifGeneral.Leave += new System.EventHandler(this.tbBonifGeneral_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Subtotal      $";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(174, 11);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(77, 20);
            this.lblSubtotal.TabIndex = 22;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Bonificación   $";
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeneral.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalGeneral.Location = new System.Drawing.Point(174, 79);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(73, 29);
            this.lblTotalGeneral.TabIndex = 25;
            this.lblTotalGeneral.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(7, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total      $";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(364, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "Forma de Pago";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Efectivo";
            // 
            // tbEfectivo
            // 
            this.tbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEfectivo.Location = new System.Drawing.Point(446, 48);
            this.tbEfectivo.Name = "tbEfectivo";
            this.tbEfectivo.Size = new System.Drawing.Size(126, 26);
            this.tbEfectivo.TabIndex = 27;
            this.tbEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEfectivo_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(355, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Débito";
            // 
            // tbDebito
            // 
            this.tbDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDebito.Location = new System.Drawing.Point(446, 87);
            this.tbDebito.Name = "tbDebito";
            this.tbDebito.Size = new System.Drawing.Size(126, 26);
            this.tbDebito.TabIndex = 29;
            this.tbDebito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDebito_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(285, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Tarj. de Crédito";
            // 
            // tbTarjCredito
            // 
            this.tbTarjCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTarjCredito.Location = new System.Drawing.Point(446, 126);
            this.tbTarjCredito.Name = "tbTarjCredito";
            this.tbTarjCredito.Size = new System.Drawing.Size(126, 26);
            this.tbTarjCredito.TabIndex = 31;
            this.tbTarjCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTarjCredito_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(337, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Cta. Cte.";
            // 
            // tbCtaCte
            // 
            this.tbCtaCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCtaCte.Location = new System.Drawing.Point(446, 165);
            this.tbCtaCte.Name = "tbCtaCte";
            this.tbCtaCte.Size = new System.Drawing.Size(126, 26);
            this.tbCtaCte.TabIndex = 33;
            // 
            // panelFormadePago
            // 
            this.panelFormadePago.Controls.Add(this.btnAceptarVenta);
            this.panelFormadePago.Controls.Add(this.btnAgregarMasProductos);
            this.panelFormadePago.Controls.Add(this.lblSaldo);
            this.panelFormadePago.Controls.Add(this.label7);
            this.panelFormadePago.Controls.Add(this.label16);
            this.panelFormadePago.Controls.Add(this.tbBonifGeneral);
            this.panelFormadePago.Controls.Add(this.tbCtaCte);
            this.panelFormadePago.Controls.Add(this.lblSubtotal);
            this.panelFormadePago.Controls.Add(this.label15);
            this.panelFormadePago.Controls.Add(this.label9);
            this.panelFormadePago.Controls.Add(this.tbTarjCredito);
            this.panelFormadePago.Controls.Add(this.label11);
            this.panelFormadePago.Controls.Add(this.label14);
            this.panelFormadePago.Controls.Add(this.lblTotalGeneral);
            this.panelFormadePago.Controls.Add(this.tbDebito);
            this.panelFormadePago.Controls.Add(this.label12);
            this.panelFormadePago.Controls.Add(this.label13);
            this.panelFormadePago.Controls.Add(this.tbEfectivo);
            this.panelFormadePago.Location = new System.Drawing.Point(9, 449);
            this.panelFormadePago.Name = "panelFormadePago";
            this.panelFormadePago.Size = new System.Drawing.Size(1029, 288);
            this.panelFormadePago.TabIndex = 35;
            this.panelFormadePago.Visible = false;
            // 
            // btnAceptarVenta
            // 
            this.btnAceptarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarVenta.Location = new System.Drawing.Point(12, 216);
            this.btnAceptarVenta.Name = "btnAceptarVenta";
            this.btnAceptarVenta.Size = new System.Drawing.Size(139, 37);
            this.btnAceptarVenta.TabIndex = 37;
            this.btnAceptarVenta.Text = "Guardar Venta";
            this.btnAceptarVenta.UseVisualStyleBackColor = true;
            this.btnAceptarVenta.Click += new System.EventHandler(this.btnAceptarVenta_Click);
            // 
            // btnAgregarMasProductos
            // 
            this.btnAgregarMasProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMasProductos.Location = new System.Drawing.Point(880, 4);
            this.btnAgregarMasProductos.Name = "btnAgregarMasProductos";
            this.btnAgregarMasProductos.Size = new System.Drawing.Size(139, 54);
            this.btnAgregarMasProductos.TabIndex = 36;
            this.btnAgregarMasProductos.Text = "Agregar mas productos";
            this.btnAgregarMasProductos.UseVisualStyleBackColor = true;
            this.btnAgregarMasProductos.Click += new System.EventHandler(this.btnAgregarMasProductos_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(578, 168);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(351, 20);
            this.lblSaldo.TabIndex = 35;
            this.lblSaldo.Text = "El cliente seleccionado tiene un saldo de $";
            this.lblSaldo.Visible = false;
            // 
            // btnPegar
            // 
            this.btnPegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPegar.Location = new System.Drawing.Point(583, 109);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(118, 32);
            this.btnPegar.TabIndex = 36;
            this.btnPegar.Text = "pegar código";
            this.btnPegar.UseVisualStyleBackColor = true;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // FrmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.btnPegar);
            this.Controls.Add(this.panelFormadePago);
            this.Controls.Add(this.btnImprimirPresupuesto);
            this.Controls.Add(this.btnCompletarVenta);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBonificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.btnEliminarSeleccionado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxUsuario);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevaVenta";
            this.Text = "FrmNuevaVenta";
            this.Load += new System.EventHandler(this.FrmNuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelFormadePago.ResumeLayout(false);
            this.panelFormadePago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ComboBox cboxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBonificacion;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCompletarVenta;
        private System.Windows.Forms.Button btnImprimirPresupuesto;
        private System.Windows.Forms.TextBox tbBonifGeneral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEfectivo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDebito;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTarjCredito;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCtaCte;
        private System.Windows.Forms.Panel panelFormadePago;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnAgregarMasProductos;
        private System.Windows.Forms.Button btnAceptarVenta;
        private System.Windows.Forms.Button btnPegar;
    }
}