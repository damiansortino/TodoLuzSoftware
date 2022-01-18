
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
            this.btnAgregarMovStock.Location = new System.Drawing.Point(15, 55);
            this.btnAgregarMovStock.Name = "btnAgregarMovStock";
            this.btnAgregarMovStock.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMovStock.TabIndex = 0;
            this.btnAgregarMovStock.Text = "Agregar";
            this.btnAgregarMovStock.UseVisualStyleBackColor = true;
            this.btnAgregarMovStock.Click += new System.EventHandler(this.btnAgregarMovStock_Click);
            // 
            // btnModificarMovStock
            // 
            this.btnModificarMovStock.Location = new System.Drawing.Point(96, 55);
            this.btnModificarMovStock.Name = "btnModificarMovStock";
            this.btnModificarMovStock.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMovStock.TabIndex = 1;
            this.btnModificarMovStock.Text = "Modificar";
            this.btnModificarMovStock.UseVisualStyleBackColor = true;
            this.btnModificarMovStock.Click += new System.EventHandler(this.btnModificarMovStock_Click);
            // 
            // btnBorrarMovStock
            // 
            this.btnBorrarMovStock.Location = new System.Drawing.Point(177, 55);
            this.btnBorrarMovStock.Name = "btnBorrarMovStock";
            this.btnBorrarMovStock.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarMovStock.TabIndex = 2;
            this.btnBorrarMovStock.Text = "Borrar";
            this.btnBorrarMovStock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipos de Movimientos de Stock";
            // 
            // dgvMuestraTiposMovStock
            // 
            this.dgvMuestraTiposMovStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraTiposMovStock.Location = new System.Drawing.Point(15, 101);
            this.dgvMuestraTiposMovStock.Name = "dgvMuestraTiposMovStock";
            this.dgvMuestraTiposMovStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestraTiposMovStock.Size = new System.Drawing.Size(237, 219);
            this.dgvMuestraTiposMovStock.TabIndex = 4;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1084, 804);
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