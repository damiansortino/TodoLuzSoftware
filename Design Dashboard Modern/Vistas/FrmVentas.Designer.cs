﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.panNuevaVenta);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 749);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
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
            this.panNuevaVenta.Size = new System.Drawing.Size(1005, 355);
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
            this.btnAgregar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(926, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(57, 42);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "+";
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
            this.dgvMuestraDetallesProductos.Location = new System.Drawing.Point(0, 109);
            this.dgvMuestraDetallesProductos.Name = "dgvMuestraDetallesProductos";
            this.dgvMuestraDetallesProductos.ReadOnly = true;
            this.dgvMuestraDetallesProductos.Size = new System.Drawing.Size(1005, 246);
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
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}