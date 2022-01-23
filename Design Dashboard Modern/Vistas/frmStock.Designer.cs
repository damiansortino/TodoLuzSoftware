
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.btnStockxProducto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvMuestraStock = new System.Windows.Forms.DataGridView();
            this.panelMovimientosStock = new System.Windows.Forms.Panel();
            this.tbCodigoProductoMovStock = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraStock)).BeginInit();
            this.panelMovimientosStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(12, 33);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(344, 25);
            this.tbFiltro.TabIndex = 0;
            this.tbFiltro.Text = "Código del Producto";
            this.tbFiltro.Enter += new System.EventHandler(this.tbFiltro_Enter);
            // 
            // btnStockxProducto
            // 
            this.btnStockxProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(207)))), ((int)(((byte)(77)))));
            this.btnStockxProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockxProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStockxProducto.Location = new System.Drawing.Point(12, 74);
            this.btnStockxProducto.Name = "btnStockxProducto";
            this.btnStockxProducto.Padding = new System.Windows.Forms.Padding(3);
            this.btnStockxProducto.Size = new System.Drawing.Size(202, 52);
            this.btnStockxProducto.TabIndex = 1;
            this.btnStockxProducto.Text = "Ver Stock Por Producto";
            this.btnStockxProducto.UseVisualStyleBackColor = false;
            this.btnStockxProducto.Click += new System.EventHandler(this.btnStockxProducto_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(207)))), ((int)(((byte)(77)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(220, 74);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(3);
            this.button3.Size = new System.Drawing.Size(227, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nuevo Movimiento de Stock";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvMuestraStock
            // 
            this.dgvMuestraStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.dgvMuestraStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraStock.Location = new System.Drawing.Point(12, 144);
            this.dgvMuestraStock.MultiSelect = false;
            this.dgvMuestraStock.Name = "dgvMuestraStock";
            this.dgvMuestraStock.ReadOnly = true;
            this.dgvMuestraStock.RowHeadersVisible = false;
            this.dgvMuestraStock.Size = new System.Drawing.Size(435, 209);
            this.dgvMuestraStock.TabIndex = 6;
            // 
            // panelMovimientosStock
            // 
            this.panelMovimientosStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(127)))), ((int)(((byte)(70)))));
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
            this.panelMovimientosStock.Size = new System.Drawing.Size(383, 341);
            this.panelMovimientosStock.TabIndex = 7;
            this.panelMovimientosStock.Visible = false;
            // 
            // tbCodigoProductoMovStock
            // 
            this.tbCodigoProductoMovStock.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoProductoMovStock.Location = new System.Drawing.Point(99, 101);
            this.tbCodigoProductoMovStock.Name = "tbCodigoProductoMovStock";
            this.tbCodigoProductoMovStock.Size = new System.Drawing.Size(232, 25);
            this.tbCodigoProductoMovStock.TabIndex = 14;
            this.tbCodigoProductoMovStock.Text = "Código del Producto";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(176, 206);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(3);
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 13;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(264, 206);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(3);
            this.button4.Size = new System.Drawing.Size(29, 31);
            this.button4.TabIndex = 12;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(214, 277);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(143, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(185)))), ((int)(((byte)(55)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(23, 277);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(142, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(214, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(215, 145);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 22);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sale";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(120, 145);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 22);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Entra";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Movimiento";
            // 
            // cboxTipoMovStock
            // 
            this.cboxTipoMovStock.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipoMovStock.FormattingEnabled = true;
            this.cboxTipoMovStock.Location = new System.Drawing.Point(181, 23);
            this.cboxTipoMovStock.Name = "cboxTipoMovStock";
            this.cboxTipoMovStock.Size = new System.Drawing.Size(183, 29);
            this.cboxTipoMovStock.TabIndex = 4;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
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