
namespace Design_Dashboard_Modern.Vistas
{
    partial class FrmVentas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnImprimirPresupuesto = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.panMediosDePago = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubtotalGeneral = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDescuentos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTarjetas = new System.Windows.Forms.TextBox();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.lblRestoPorPagar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEfectivo = new System.Windows.Forms.TextBox();
            this.btnMediosDePago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptarVenta = new System.Windows.Forms.Button();
            this.panNuevaVenta = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescuentoProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMuestraDetallesProductos = new System.Windows.Forms.DataGridView();
            this.tbSubtotalProducto = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panMediosDePago.SuspendLayout();
            this.panNuevaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraDetallesProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnImprimirPresupuesto);
            this.splitContainer1.Panel2.Controls.Add(this.btnQuitarProducto);
            this.splitContainer1.Panel2.Controls.Add(this.panMediosDePago);
            this.splitContainer1.Panel2.Controls.Add(this.btnMediosDePago);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnAceptarVenta);
            this.splitContainer1.Panel2.Controls.Add(this.panNuevaVenta);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 749);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // btnImprimirPresupuesto
            // 
            this.btnImprimirPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(207)))), ((int)(((byte)(77)))));
            this.btnImprimirPresupuesto.Enabled = false;
            this.btnImprimirPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirPresupuesto.Location = new System.Drawing.Point(744, 602);
            this.btnImprimirPresupuesto.Name = "btnImprimirPresupuesto";
            this.btnImprimirPresupuesto.Size = new System.Drawing.Size(145, 54);
            this.btnImprimirPresupuesto.TabIndex = 17;
            this.btnImprimirPresupuesto.Text = "Imprimir Presupuesto";
            this.btnImprimirPresupuesto.UseVisualStyleBackColor = false;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnQuitarProducto.Enabled = false;
            this.btnQuitarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProducto.Location = new System.Drawing.Point(897, 375);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(133, 62);
            this.btnQuitarProducto.TabIndex = 14;
            this.btnQuitarProducto.Text = "Quitar Producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            this.btnQuitarProducto.Visible = false;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // panMediosDePago
            // 
            this.panMediosDePago.Controls.Add(this.label7);
            this.panMediosDePago.Controls.Add(this.lblSubtotalGeneral);
            this.panMediosDePago.Controls.Add(this.label9);
            this.panMediosDePago.Controls.Add(this.tbDescuentos);
            this.panMediosDePago.Controls.Add(this.label11);
            this.panMediosDePago.Controls.Add(this.label10);
            this.panMediosDePago.Controls.Add(this.tbTarjetas);
            this.panMediosDePago.Controls.Add(this.lblTotalGeneral);
            this.panMediosDePago.Controls.Add(this.lblRestoPorPagar);
            this.panMediosDePago.Controls.Add(this.label8);
            this.panMediosDePago.Controls.Add(this.tbEfectivo);
            this.panMediosDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panMediosDePago.Location = new System.Drawing.Point(15, 375);
            this.panMediosDePago.Name = "panMediosDePago";
            this.panMediosDePago.Size = new System.Drawing.Size(511, 275);
            this.panMediosDePago.TabIndex = 16;
            this.panMediosDePago.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Subtotal General";
            // 
            // lblSubtotalGeneral
            // 
            this.lblSubtotalGeneral.AutoSize = true;
            this.lblSubtotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalGeneral.Location = new System.Drawing.Point(231, 69);
            this.lblSubtotalGeneral.Name = "lblSubtotalGeneral";
            this.lblSubtotalGeneral.Size = new System.Drawing.Size(77, 24);
            this.lblSubtotalGeneral.TabIndex = 2;
            this.lblSubtotalGeneral.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Descuentos";
            // 
            // tbDescuentos
            // 
            this.tbDescuentos.Location = new System.Drawing.Point(232, 96);
            this.tbDescuentos.Name = "tbDescuentos";
            this.tbDescuentos.Size = new System.Drawing.Size(100, 22);
            this.tbDescuentos.TabIndex = 4;
            this.tbDescuentos.Leave += new System.EventHandler(this.tbDescuentos_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tarjetas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total a Pagar";
            // 
            // tbTarjetas
            // 
            this.tbTarjetas.Location = new System.Drawing.Point(234, 205);
            this.tbTarjetas.Name = "tbTarjetas";
            this.tbTarjetas.Size = new System.Drawing.Size(100, 22);
            this.tbTarjetas.TabIndex = 11;
            this.tbTarjetas.Leave += new System.EventHandler(this.tbTarjetas_Leave);
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeneral.Location = new System.Drawing.Point(231, 135);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(51, 24);
            this.lblTotalGeneral.TabIndex = 6;
            this.lblTotalGeneral.Text = "Total";
            // 
            // lblRestoPorPagar
            // 
            this.lblRestoPorPagar.AutoSize = true;
            this.lblRestoPorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestoPorPagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRestoPorPagar.Location = new System.Drawing.Point(58, 12);
            this.lblRestoPorPagar.Name = "lblRestoPorPagar";
            this.lblRestoPorPagar.Size = new System.Drawing.Size(115, 24);
            this.lblRestoPorPagar.TabIndex = 10;
            this.lblRestoPorPagar.Text = "Restan $ ...";
            this.lblRestoPorPagar.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Efectivo";
            // 
            // tbEfectivo
            // 
            this.tbEfectivo.Location = new System.Drawing.Point(234, 167);
            this.tbEfectivo.Name = "tbEfectivo";
            this.tbEfectivo.Size = new System.Drawing.Size(100, 22);
            this.tbEfectivo.TabIndex = 8;
            this.tbEfectivo.Leave += new System.EventHandler(this.tbEfectivo_Leave);
            // 
            // btnMediosDePago
            // 
            this.btnMediosDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediosDePago.Location = new System.Drawing.Point(601, 375);
            this.btnMediosDePago.Name = "btnMediosDePago";
            this.btnMediosDePago.Size = new System.Drawing.Size(141, 36);
            this.btnMediosDePago.TabIndex = 15;
            this.btnMediosDePago.Text = "Medios de Pago";
            this.btnMediosDePago.UseVisualStyleBackColor = true;
            this.btnMediosDePago.Visible = false;
            this.btnMediosDePago.Click += new System.EventHandler(this.btnMediosDePago_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(872, 510);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 54);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptarVenta
            // 
            this.btnAceptarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(185)))), ((int)(((byte)(55)))));
            this.btnAceptarVenta.Enabled = false;
            this.btnAceptarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarVenta.Location = new System.Drawing.Point(643, 514);
            this.btnAceptarVenta.Name = "btnAceptarVenta";
            this.btnAceptarVenta.Size = new System.Drawing.Size(145, 54);
            this.btnAceptarVenta.TabIndex = 13;
            this.btnAceptarVenta.Text = "Aceptar Venta";
            this.btnAceptarVenta.UseVisualStyleBackColor = false;
            this.btnAceptarVenta.Click += new System.EventHandler(this.btnAceptarVenta_Click);
            // 
            // panNuevaVenta
            // 
            this.panNuevaVenta.Controls.Add(this.label12);
            this.panNuevaVenta.Controls.Add(this.cboxCliente);
            this.panNuevaVenta.Controls.Add(this.label6);
            this.panNuevaVenta.Controls.Add(this.tbDescuentoProducto);
            this.panNuevaVenta.Controls.Add(this.btnAgregar);
            this.panNuevaVenta.Controls.Add(this.label5);
            this.panNuevaVenta.Controls.Add(this.label4);
            this.panNuevaVenta.Controls.Add(this.label3);
            this.panNuevaVenta.Controls.Add(this.label2);
            this.panNuevaVenta.Controls.Add(this.label1);
            this.panNuevaVenta.Controls.Add(this.dgvMuestraDetallesProductos);
            this.panNuevaVenta.Controls.Add(this.tbSubtotalProducto);
            this.panNuevaVenta.Controls.Add(this.tbPrecio);
            this.panNuevaVenta.Controls.Add(this.tbCantidad);
            this.panNuevaVenta.Controls.Add(this.tbCodigo);
            this.panNuevaVenta.Controls.Add(this.tbNombreProducto);
            this.panNuevaVenta.Location = new System.Drawing.Point(11, 3);
            this.panNuevaVenta.Name = "panNuevaVenta";
            this.panNuevaVenta.Size = new System.Drawing.Size(1060, 366);
            this.panNuevaVenta.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Cliente";
            // 
            // cboxCliente
            // 
            this.cboxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(86, 3);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(121, 28);
            this.cboxCliente.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(751, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descuento";
            // 
            // tbDescuentoProducto
            // 
            this.tbDescuentoProducto.Location = new System.Drawing.Point(760, 102);
            this.tbDescuentoProducto.Name = "tbDescuentoProducto";
            this.tbDescuentoProducto.Size = new System.Drawing.Size(88, 20);
            this.tbDescuentoProducto.TabIndex = 3;
            this.tbDescuentoProducto.Leave += new System.EventHandler(this.tbDescuentoProducto_Leave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(185)))), ((int)(((byte)(55)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(948, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 53);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(857, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del Producto";
            // 
            // dgvMuestraDetallesProductos
            // 
            this.dgvMuestraDetallesProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraDetallesProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMuestraDetallesProductos.Location = new System.Drawing.Point(0, 138);
            this.dgvMuestraDetallesProductos.Name = "dgvMuestraDetallesProductos";
            this.dgvMuestraDetallesProductos.ReadOnly = true;
            this.dgvMuestraDetallesProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestraDetallesProductos.Size = new System.Drawing.Size(1060, 228);
            this.dgvMuestraDetallesProductos.TabIndex = 5;
            this.dgvMuestraDetallesProductos.TabStop = false;
            this.dgvMuestraDetallesProductos.Visible = false;
            this.dgvMuestraDetallesProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMuestraDetallesProductos_MouseClick);
            // 
            // tbSubtotalProducto
            // 
            this.tbSubtotalProducto.Location = new System.Drawing.Point(865, 102);
            this.tbSubtotalProducto.Name = "tbSubtotalProducto";
            this.tbSubtotalProducto.Size = new System.Drawing.Size(70, 20);
            this.tbSubtotalProducto.TabIndex = 4;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(647, 102);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(99, 20);
            this.tbPrecio.TabIndex = 3;
            this.tbPrecio.TabStop = false;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(590, 102);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(41, 20);
            this.tbCantidad.TabIndex = 2;
            this.tbCantidad.Leave += new System.EventHandler(this.tbCantidad_Leave);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(445, 102);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(131, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbNombreProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNombreProducto.Location = new System.Drawing.Point(2, 102);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(437, 20);
            this.tbNombreProducto.TabIndex = 0;
            this.tbNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreProducto_KeyPress);
            this.tbNombreProducto.Leave += new System.EventHandler(this.tbNombreProducto_Leave);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panMediosDePago.ResumeLayout(false);
            this.panMediosDePago.PerformLayout();
            this.panNuevaVenta.ResumeLayout(false);
            this.panNuevaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraDetallesProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panNuevaVenta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMuestraDetallesProductos;
        private System.Windows.Forms.TextBox tbSubtotalProducto;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombreProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescuentoProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptarVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTarjetas;
        private System.Windows.Forms.Label lblRestoPorPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEfectivo;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDescuentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSubtotalGeneral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panMediosDePago;
        private System.Windows.Forms.Button btnMediosDePago;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnImprimirPresupuesto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboxCliente;
    }
}