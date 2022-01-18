
namespace Design_Dashboard_Modern.Vistas
{
    partial class frmStock
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
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.btnStockxProducto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvMuestraStock = new System.Windows.Forms.DataGridView();
            this.panelMovimientosStock = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxTipoMovStock = new System.Windows.Forms.ComboBox();
            this.tbCodigoProductoMovStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraStock)).BeginInit();
            this.panelMovimientosStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(12, 60);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(174, 20);
            this.tbFiltro.TabIndex = 1;
            this.tbFiltro.Text = "Código de P\r\nroducto";
            this.tbFiltro.Enter += new System.EventHandler(this.tbFiltro_Enter);
            // 
            // btnStockxProducto
            // 
            this.btnStockxProducto.Location = new System.Drawing.Point(12, 86);
            this.btnStockxProducto.Name = "btnStockxProducto";
            this.btnStockxProducto.Size = new System.Drawing.Size(174, 35);
            this.btnStockxProducto.TabIndex = 2;
            this.btnStockxProducto.Text = "Ver Stock Por Producto";
            this.btnStockxProducto.UseVisualStyleBackColor = true;
            this.btnStockxProducto.Click += new System.EventHandler(this.btnStockxProducto_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(258, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nuevo Movimiento de Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvMuestraStock
            // 
            this.dgvMuestraStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraStock.Location = new System.Drawing.Point(12, 144);
            this.dgvMuestraStock.Name = "dgvMuestraStock";
            this.dgvMuestraStock.Size = new System.Drawing.Size(420, 191);
            this.dgvMuestraStock.TabIndex = 6;
            // 
            // panelMovimientosStock
            // 
            this.panelMovimientosStock.Controls.Add(this.tbCodigoProductoMovStock);
            this.panelMovimientosStock.Controls.Add(this.button5);
            this.panelMovimientosStock.Controls.Add(this.button4);
            this.panelMovimientosStock.Controls.Add(this.button2);
            this.panelMovimientosStock.Controls.Add(this.button1);
            this.panelMovimientosStock.Controls.Add(this.textBox1);
            this.panelMovimientosStock.Controls.Add(this.label3);
            this.panelMovimientosStock.Controls.Add(this.radioButton2);
            this.panelMovimientosStock.Controls.Add(this.radioButton1);
            this.panelMovimientosStock.Controls.Add(this.label2);
            this.panelMovimientosStock.Controls.Add(this.cboxTipoMovStock);
            this.panelMovimientosStock.Location = new System.Drawing.Point(468, 12);
            this.panelMovimientosStock.Name = "panelMovimientosStock";
            this.panelMovimientosStock.Size = new System.Drawing.Size(383, 328);
            this.panelMovimientosStock.TabIndex = 7;
            this.panelMovimientosStock.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(179, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(267, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(215, 145);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sale";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(120, 145);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Entra";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Movimiento";
            // 
            // cboxTipoMovStock
            // 
            this.cboxTipoMovStock.FormattingEnabled = true;
            this.cboxTipoMovStock.Location = new System.Drawing.Point(181, 23);
            this.cboxTipoMovStock.Name = "cboxTipoMovStock";
            this.cboxTipoMovStock.Size = new System.Drawing.Size(173, 21);
            this.cboxTipoMovStock.TabIndex = 4;
            // 
            // tbCodigoProductoMovStock
            // 
            this.tbCodigoProductoMovStock.Location = new System.Drawing.Point(120, 79);
            this.tbCodigoProductoMovStock.Name = "tbCodigoProductoMovStock";
            this.tbCodigoProductoMovStock.Size = new System.Drawing.Size(162, 20);
            this.tbCodigoProductoMovStock.TabIndex = 14;
            this.tbCodigoProductoMovStock.Text = "Código de P\r\nroducto";
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.panelMovimientosStock);
            this.Controls.Add(this.dgvMuestraStock);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStockxProducto);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStock";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraStock)).EndInit();
            this.panelMovimientosStock.ResumeLayout(false);
            this.panelMovimientosStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button btnStockxProducto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvMuestraStock;
        private System.Windows.Forms.Panel panelMovimientosStock;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxTipoMovStock;
        private System.Windows.Forms.TextBox tbCodigoProductoMovStock;
    }
}