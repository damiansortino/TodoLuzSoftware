
namespace Design_Dashboard_Modern.Vistas
{
    partial class frmClientes
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
            this.dgvMuestraClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMuestraClientes
            // 
            this.dgvMuestraClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMuestraClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvMuestraClientes.MultiSelect = false;
            this.dgvMuestraClientes.Name = "dgvMuestraClientes";
            this.dgvMuestraClientes.ReadOnly = true;
            this.dgvMuestraClientes.RowHeadersVisible = false;
            this.dgvMuestraClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestraClientes.Size = new System.Drawing.Size(1044, 275);
            this.dgvMuestraClientes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMuestraClientes);
            this.panel1.Location = new System.Drawing.Point(12, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 275);
            this.panel1.TabIndex = 1;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(12, 411);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(103, 23);
            this.btnNuevoCliente.TabIndex = 2;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(131, 411);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(103, 23);
            this.btnEditarCliente.TabIndex = 3;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(250, 411);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarCliente.TabIndex = 4;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1068, 710);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestraClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
    }
}