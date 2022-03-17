
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
            this.dgvMuestraUsuarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminaUsuario = new System.Windows.Forms.Button();
            this.btnBlanquearClave = new System.Windows.Forms.Button();
            this.btnAgregaUsuario = new System.Windows.Forms.Button();
            this.btnCambiarTipoUser = new System.Windows.Forms.Button();
            this.dgvMuestraMovCaja = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminiarMovCaja = new System.Windows.Forms.Button();
            this.btnModMovCaja = new System.Windows.Forms.Button();
            this.btnAgregarMovCaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraTiposMovStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraMovCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarMovStock
            // 
            this.btnAgregarMovStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(185)))), ((int)(((byte)(55)))));
            this.btnAgregarMovStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMovStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMovStock.Location = new System.Drawing.Point(15, 42);
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
            this.btnModificarMovStock.Location = new System.Drawing.Point(122, 42);
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
            this.btnBorrarMovStock.Location = new System.Drawing.Point(62, 88);
            this.btnBorrarMovStock.Name = "btnBorrarMovStock";
            this.btnBorrarMovStock.Size = new System.Drawing.Size(101, 40);
            this.btnBorrarMovStock.TabIndex = 2;
            this.btnBorrarMovStock.Text = "Borrar";
            this.btnBorrarMovStock.UseVisualStyleBackColor = false;
            this.btnBorrarMovStock.Click += new System.EventHandler(this.btnBorrarMovStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipos de Movimientos de Stock";
            // 
            // dgvMuestraTiposMovStock
            // 
            this.dgvMuestraTiposMovStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMuestraTiposMovStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMuestraTiposMovStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.dgvMuestraTiposMovStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMuestraTiposMovStock.Location = new System.Drawing.Point(40, 134);
            this.dgvMuestraTiposMovStock.MultiSelect = false;
            this.dgvMuestraTiposMovStock.Name = "dgvMuestraTiposMovStock";
            this.dgvMuestraTiposMovStock.ReadOnly = true;
            this.dgvMuestraTiposMovStock.RowHeadersVisible = false;
            this.dgvMuestraTiposMovStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMuestraTiposMovStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestraTiposMovStock.Size = new System.Drawing.Size(161, 234);
            this.dgvMuestraTiposMovStock.TabIndex = 4;
            this.dgvMuestraTiposMovStock.TabStop = false;
            this.dgvMuestraTiposMovStock.Click += new System.EventHandler(this.dgvMuestraTiposMovStock_Click);
            // 
            // dgvMuestraUsuarios
            // 
            this.dgvMuestraUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMuestraUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMuestraUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.dgvMuestraUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraUsuarios.Location = new System.Drawing.Point(304, 101);
            this.dgvMuestraUsuarios.MultiSelect = false;
            this.dgvMuestraUsuarios.Name = "dgvMuestraUsuarios";
            this.dgvMuestraUsuarios.ReadOnly = true;
            this.dgvMuestraUsuarios.RowHeadersVisible = false;
            this.dgvMuestraUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMuestraUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestraUsuarios.Size = new System.Drawing.Size(750, 274);
            this.dgvMuestraUsuarios.TabIndex = 9;
            this.dgvMuestraUsuarios.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(646, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuarios";
            // 
            // btnEliminaUsuario
            // 
            this.btnEliminaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnEliminaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminaUsuario.Location = new System.Drawing.Point(622, 55);
            this.btnEliminaUsuario.Name = "btnEliminaUsuario";
            this.btnEliminaUsuario.Size = new System.Drawing.Size(151, 40);
            this.btnEliminaUsuario.TabIndex = 7;
            this.btnEliminaUsuario.Text = "Eliminar Usuario";
            this.btnEliminaUsuario.UseVisualStyleBackColor = false;
            this.btnEliminaUsuario.Click += new System.EventHandler(this.btnEliminaUsuario_Click);
            // 
            // btnBlanquearClave
            // 
            this.btnBlanquearClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(207)))), ((int)(((byte)(77)))));
            this.btnBlanquearClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlanquearClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanquearClave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlanquearClave.Location = new System.Drawing.Point(472, 55);
            this.btnBlanquearClave.Name = "btnBlanquearClave";
            this.btnBlanquearClave.Size = new System.Drawing.Size(144, 40);
            this.btnBlanquearClave.TabIndex = 6;
            this.btnBlanquearClave.Text = "Blanquear Clave";
            this.btnBlanquearClave.UseVisualStyleBackColor = false;
            this.btnBlanquearClave.Click += new System.EventHandler(this.btnBlanquearClave_Click);
            // 
            // btnAgregaUsuario
            // 
            this.btnAgregaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(185)))), ((int)(((byte)(55)))));
            this.btnAgregaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregaUsuario.Location = new System.Drawing.Point(365, 55);
            this.btnAgregaUsuario.Name = "btnAgregaUsuario";
            this.btnAgregaUsuario.Size = new System.Drawing.Size(101, 40);
            this.btnAgregaUsuario.TabIndex = 5;
            this.btnAgregaUsuario.Text = "Agregar";
            this.btnAgregaUsuario.UseVisualStyleBackColor = false;
            this.btnAgregaUsuario.Click += new System.EventHandler(this.btnAgregaUsuario_Click);
            // 
            // btnCambiarTipoUser
            // 
            this.btnCambiarTipoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(185)))), ((int)(((byte)(55)))));
            this.btnCambiarTipoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarTipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarTipoUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarTipoUser.Location = new System.Drawing.Point(779, 55);
            this.btnCambiarTipoUser.Name = "btnCambiarTipoUser";
            this.btnCambiarTipoUser.Size = new System.Drawing.Size(207, 40);
            this.btnCambiarTipoUser.TabIndex = 10;
            this.btnCambiarTipoUser.Text = "Cambiar tipo de usuario";
            this.btnCambiarTipoUser.UseVisualStyleBackColor = false;
            this.btnCambiarTipoUser.Click += new System.EventHandler(this.btnCambiarTipoUser_Click);
            // 
            // dgvMuestraMovCaja
            // 
            this.dgvMuestraMovCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMuestraMovCaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMuestraMovCaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.dgvMuestraMovCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMuestraMovCaja.Location = new System.Drawing.Point(80, 486);
            this.dgvMuestraMovCaja.MultiSelect = false;
            this.dgvMuestraMovCaja.Name = "dgvMuestraMovCaja";
            this.dgvMuestraMovCaja.ReadOnly = true;
            this.dgvMuestraMovCaja.RowHeadersVisible = false;
            this.dgvMuestraMovCaja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMuestraMovCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestraMovCaja.Size = new System.Drawing.Size(161, 192);
            this.dgvMuestraMovCaja.TabIndex = 15;
            this.dgvMuestraMovCaja.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipos de Movimientos de Caja";
            // 
            // btnEliminiarMovCaja
            // 
            this.btnEliminiarMovCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnEliminiarMovCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminiarMovCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminiarMovCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminiarMovCaja.Location = new System.Drawing.Point(230, 428);
            this.btnEliminiarMovCaja.Name = "btnEliminiarMovCaja";
            this.btnEliminiarMovCaja.Size = new System.Drawing.Size(101, 40);
            this.btnEliminiarMovCaja.TabIndex = 13;
            this.btnEliminiarMovCaja.Text = "Borrar";
            this.btnEliminiarMovCaja.UseVisualStyleBackColor = false;
            // 
            // btnModMovCaja
            // 
            this.btnModMovCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(207)))), ((int)(((byte)(77)))));
            this.btnModMovCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModMovCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModMovCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModMovCaja.Location = new System.Drawing.Point(122, 428);
            this.btnModMovCaja.Name = "btnModMovCaja";
            this.btnModMovCaja.Size = new System.Drawing.Size(102, 40);
            this.btnModMovCaja.TabIndex = 12;
            this.btnModMovCaja.Text = "Modificar";
            this.btnModMovCaja.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMovCaja
            // 
            this.btnAgregarMovCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(185)))), ((int)(((byte)(55)))));
            this.btnAgregarMovCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMovCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMovCaja.Location = new System.Drawing.Point(15, 428);
            this.btnAgregarMovCaja.Name = "btnAgregarMovCaja";
            this.btnAgregarMovCaja.Size = new System.Drawing.Size(101, 40);
            this.btnAgregarMovCaja.TabIndex = 11;
            this.btnAgregarMovCaja.Text = "Agregar";
            this.btnAgregarMovCaja.UseVisualStyleBackColor = false;
            this.btnAgregarMovCaja.Click += new System.EventHandler(this.btnAgregarMovCaja_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(127)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.dgvMuestraMovCaja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminiarMovCaja);
            this.Controls.Add(this.btnModMovCaja);
            this.Controls.Add(this.btnAgregarMovCaja);
            this.Controls.Add(this.btnCambiarTipoUser);
            this.Controls.Add(this.dgvMuestraUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminaUsuario);
            this.Controls.Add(this.btnBlanquearClave);
            this.Controls.Add(this.btnAgregaUsuario);
            this.Controls.Add(this.dgvMuestraTiposMovStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrarMovStock);
            this.Controls.Add(this.btnModificarMovStock);
            this.Controls.Add(this.btnAgregarMovStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraTiposMovStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraMovCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMovStock;
        private System.Windows.Forms.Button btnModificarMovStock;
        private System.Windows.Forms.Button btnBorrarMovStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMuestraTiposMovStock;
        private System.Windows.Forms.DataGridView dgvMuestraUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminaUsuario;
        private System.Windows.Forms.Button btnBlanquearClave;
        private System.Windows.Forms.Button btnAgregaUsuario;
        private System.Windows.Forms.Button btnCambiarTipoUser;
        private System.Windows.Forms.DataGridView dgvMuestraMovCaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminiarMovCaja;
        private System.Windows.Forms.Button btnModMovCaja;
        private System.Windows.Forms.Button btnAgregarMovCaja;
    }
}