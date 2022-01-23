
namespace Design_Dashboard_Modern.Vistas
{
    partial class frmConfiguracion
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
            this.btnAgregarMovStock = new System.Windows.Forms.Button();
            this.btnModificarMovStock = new System.Windows.Forms.Button();
            this.btnBorrarMovStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMuestraTiposMovStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraTiposMovStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarMovStock
            // 
            this.btnAgregarMovStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(185)))), ((int)(((byte)(55)))));
            this.btnAgregarMovStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMovStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMovStock.Location = new System.Drawing.Point(15, 55);
            this.btnAgregarMovStock.Name = "btnAgregarMovStock";
            this.btnAgregarMovStock.Size = new System.Drawing.Size(101, 40);
            this.btnAgregarMovStock.TabIndex = 0;
            this.btnAgregarMovStock.Text = "Agregar";
            this.btnAgregarMovStock.UseVisualStyleBackColor = false;
            this.btnAgregarMovStock.Click += new System.EventHandler(this.btnAgregarMovStock_Click);
            // 
            // btnModificarMovStock
            // 
            this.btnModificarMovStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(207)))), ((int)(((byte)(77)))));
            this.btnModificarMovStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMovStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMovStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarMovStock.Location = new System.Drawing.Point(122, 55);
            this.btnModificarMovStock.Name = "btnModificarMovStock";
            this.btnModificarMovStock.Size = new System.Drawing.Size(102, 40);
            this.btnModificarMovStock.TabIndex = 1;
            this.btnModificarMovStock.Text = "Modificar";
            this.btnModificarMovStock.UseVisualStyleBackColor = false;
            this.btnModificarMovStock.Click += new System.EventHandler(this.btnModificarMovStock_Click);
            // 
            // btnBorrarMovStock
            // 
            this.btnBorrarMovStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnBorrarMovStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarMovStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarMovStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrarMovStock.Location = new System.Drawing.Point(230, 55);
            this.btnBorrarMovStock.Name = "btnBorrarMovStock";
            this.btnBorrarMovStock.Size = new System.Drawing.Size(94, 40);
            this.btnBorrarMovStock.TabIndex = 2;
            this.btnBorrarMovStock.Text = "Borrar";
            this.btnBorrarMovStock.UseVisualStyleBackColor = false;
            this.btnBorrarMovStock.Click += new System.EventHandler(this.btnBorrarMovStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipos de Movimientos de Stock";
            // 
            // dgvMuestraTiposMovStock
            // 
            this.dgvMuestraTiposMovStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.dgvMuestraTiposMovStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraTiposMovStock.Location = new System.Drawing.Point(15, 101);
            this.dgvMuestraTiposMovStock.MultiSelect = false;
            this.dgvMuestraTiposMovStock.Name = "dgvMuestraTiposMovStock";
            this.dgvMuestraTiposMovStock.ReadOnly = true;
            this.dgvMuestraTiposMovStock.RowHeadersVisible = false;
            this.dgvMuestraTiposMovStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestraTiposMovStock.Size = new System.Drawing.Size(309, 186);
            this.dgvMuestraTiposMovStock.TabIndex = 4;
            this.dgvMuestraTiposMovStock.Click += new System.EventHandler(this.dgvMuestraTiposMovStock_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(127)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.dgvMuestraTiposMovStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrarMovStock);
            this.Controls.Add(this.btnModificarMovStock);
            this.Controls.Add(this.btnAgregarMovStock);
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraTiposMovStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMovStock;
        private System.Windows.Forms.Button btnModificarMovStock;
        private System.Windows.Forms.Button btnBorrarMovStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMuestraTiposMovStock;
    }
}