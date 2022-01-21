
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
            this.panMediosDePago = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubtotalGeneral = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDescuentos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.lblRestoPorPagar = new System.Windows.Forms.Label();
            this.lblAcumulaDescuentos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEfectivo = new System.Windows.Forms.TextBox();
            this.btnMediosDePago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptarVenta = new System.Windows.Forms.Button();
            this.panNuevaVenta = new System.Windows.Forms.Panel();
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
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnImprimirPresupuesto = new System.Windows.Forms.Button();
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
            // panMediosDePago
            // 
            this.panMediosDePago.Controls.Add(this.label7);
            this.panMediosDePago.Controls.Add(this.lblSubtotalGeneral);
            this.panMediosDePago.Controls.Add(this.label9);
            this.panMediosDePago.Controls.Add(this.tbDescuentos);
            this.panMediosDePago.Controls.Add(this.label11);
            this.panMediosDePago.Controls.Add(this.label10);
            this.panMediosDePago.Controls.Add(this.textBox1);
            this.panMediosDePago.Controls.Add(this.lblTotalGeneral);
            this.panMediosDePago.Controls.Add(this.lblRestoPorPagar);
            this.panMediosDePago.Controls.Add(this.lblAcumulaDescuentos);
            this.panMediosDePago.Controls.Add(this.label8);
            this.panMediosDePago.Controls.Add(this.tbEfectivo);
            this.panMediosDePago.Location = new System.Drawing.Point(15, 375);
            this.panMediosDePago.Name = "panMediosDePago";
            this.panMediosDePago.Size = new System.Drawing.Size(494, 288);
            this.panMediosDePago.TabIndex = 16;
            this.panMediosDePago.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Subtotal General";
            // 
            // lblSubtotalGeneral
            // 
            this.lblSubtotalGeneral.AutoSize = true;
            this.lblSubtotalGeneral.Location = new System.Drawing.Point(139, 69);
            this.lblSubtotalGeneral.Name = "lblSubtotalGeneral";
            this.lblSubtotalGeneral.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotalGeneral.TabIndex = 2;
            this.lblSubtotalGeneral.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Descuentos";
            // 
            // tbDescuentos
            // 
            this.tbDescuentos.Location = new System.Drawing.Point(140, 96);
            this.tbDescuentos.Name = "tbDescuentos";
            this.tbDescuentos.Size = new System.Drawing.Size(100, 20);
            this.tbDescuentos.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tarjetas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total a Pagar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Location = new System.Drawing.Point(139, 135);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(31, 13);
            this.lblTotalGeneral.TabIndex = 6;
            this.lblTotalGeneral.Text = "Total";
            // 
            // lblRestoPorPagar
            // 
            this.lblRestoPorPagar.AutoSize = true;
            this.lblRestoPorPagar.Location = new System.Drawing.Point(246, 18);
            this.lblRestoPorPagar.Name = "lblRestoPorPagar";
            this.lblRestoPorPagar.Size = new System.Drawing.Size(62, 13);
            this.lblRestoPorPagar.TabIndex = 10;
            this.lblRestoPorPagar.Text = "Restan $ ...";
            // 
            // lblAcumulaDescuentos
            // 
            this.lblAcumulaDescuentos.AutoSize = true;
            this.lblAcumulaDescuentos.Location = new System.Drawing.Point(260, 99);
            this.lblAcumulaDescuentos.Name = "lblAcumulaDescuentos";
            this.lblAcumulaDescuentos.Size = new System.Drawing.Size(205, 13);
            this.lblAcumulaDescuentos.TabIndex = 7;
            this.lblAcumulaDescuentos.Text = "Descuentos acumulados en los productos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Efectivo";
            // 
            // tbEfectivo
            // 
            this.tbEfectivo.Location = new System.Drawing.Point(142, 167);
            this.tbEfectivo.Name = "tbEfectivo";
            this.tbEfectivo.Size = new System.Drawing.Size(100, 20);
            this.tbEfectivo.TabIndex = 8;
            // 
            // btnMediosDePago
            // 
            this.btnMediosDePago.Location = new System.Drawing.Point(525, 375);
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
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(884, 510);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 36);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptarVenta
            // 
            this.btnAceptarVenta.Enabled = false;
            this.btnAceptarVenta.Location = new System.Drawing.Point(642, 510);
            this.btnAceptarVenta.Name = "btnAceptarVenta";
            this.btnAceptarVenta.Size = new System.Drawing.Size(141, 36);
            this.btnAceptarVenta.TabIndex = 13;
            this.btnAceptarVenta.Text = "Aceptar Venta";
            this.btnAceptarVenta.UseVisualStyleBackColor = true;
            // 
            // panNuevaVenta
            // 
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
            this.panNuevaVenta.Location = new System.Drawing.Point(11, 14);
            this.panNuevaVenta.Name = "panNuevaVenta";
            this.panNuevaVenta.Size = new System.Drawing.Size(1027, 355);
            this.panNuevaVenta.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descuento";
            // 
            // tbDescuentoProducto
            // 
            this.tbDescuentoProducto.Location = new System.Drawing.Point(736, 57);
            this.tbDescuentoProducto.Name = "tbDescuentoProducto";
            this.tbDescuentoProducto.Size = new System.Drawing.Size(88, 20);
            this.tbDescuentoProducto.TabIndex = 3;
            this.tbDescuentoProducto.Leave += new System.EventHandler(this.tbDescuentoProducto_Leave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(925, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 53);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(826, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(659, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del Producto";
            // 
            // dgvMuestraDetallesProductos
            // 
            this.dgvMuestraDetallesProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraDetallesProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMuestraDetallesProductos.Location = new System.Drawing.Point(0, 83);
            this.dgvMuestraDetallesProductos.Name = "dgvMuestraDetallesProductos";
            this.dgvMuestraDetallesProductos.ReadOnly = true;
            this.dgvMuestraDetallesProductos.Size = new System.Drawing.Size(1027, 272);
            this.dgvMuestraDetallesProductos.TabIndex = 5;
            this.dgvMuestraDetallesProductos.TabStop = false;
            this.dgvMuestraDetallesProductos.Visible = false;
            // 
            // tbSubtotalProducto
            // 
            this.tbSubtotalProducto.Location = new System.Drawing.Point(830, 57);
            this.tbSubtotalProducto.Name = "tbSubtotalProducto";
            this.tbSubtotalProducto.Size = new System.Drawing.Size(70, 20);
            this.tbSubtotalProducto.TabIndex = 4;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(631, 57);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(99, 20);
            this.tbPrecio.TabIndex = 3;
            this.tbPrecio.TabStop = false;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(584, 57);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(41, 20);
            this.tbCantidad.TabIndex = 2;
            this.tbCantidad.Leave += new System.EventHandler(this.tbCantidad_Leave);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(447, 57);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(131, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbNombreProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNombreProducto.Location = new System.Drawing.Point(4, 57);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(437, 20);
            this.tbNombreProducto.TabIndex = 0;
            this.tbNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreProducto_KeyPress);
            this.tbNombreProducto.Leave += new System.EventHandler(this.tbNombreProducto_Leave);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProducto.Location = new System.Drawing.Point(924, 371);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(114, 42);
            this.btnQuitarProducto.TabIndex = 14;
            this.btnQuitarProducto.Text = "Quitar Producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Visible = false;
            // 
            // btnImprimirPresupuesto
            // 
            this.btnImprimirPresupuesto.Enabled = false;
            this.btnImprimirPresupuesto.Location = new System.Drawing.Point(642, 601);
            this.btnImprimirPresupuesto.Name = "btnImprimirPresupuesto";
            this.btnImprimirPresupuesto.Size = new System.Drawing.Size(141, 36);
            this.btnImprimirPresupuesto.TabIndex = 17;
            this.btnImprimirPresupuesto.Text = "Imprimir Presupuesto";
            this.btnImprimirPresupuesto.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRestoPorPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEfectivo;
        private System.Windows.Forms.Label lblAcumulaDescuentos;
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
    }
}