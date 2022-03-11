
namespace Design_Dashboard_Modern.Vistas
{
    partial class popupCambiarTipoUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblTipoUer = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLlaveMaestra = new System.Windows.Forms.TextBox();
            this.panelLlaveMaestra = new System.Windows.Forms.Panel();
            this.panelLlaveMaestra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(104, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // cboxTipoUsuario
            // 
            this.cboxTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipoUsuario.FormattingEnabled = true;
            this.cboxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Ventas",
            "Caja",
            "Carga de Productos",
            "Master"});
            this.cboxTipoUsuario.Location = new System.Drawing.Point(347, 75);
            this.cboxTipoUsuario.Name = "cboxTipoUsuario";
            this.cboxTipoUsuario.Size = new System.Drawing.Size(218, 28);
            this.cboxTipoUsuario.TabIndex = 1;
            this.cboxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cboxTipoUsuario_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "seleccione el nuevo tipo de usuario";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(223, 193);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(143, 63);
            this.btnCambiar.TabIndex = 3;
            this.btnCambiar.Text = "Cambiar el tipo de usuario";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblTipoUer
            // 
            this.lblTipoUer.AutoSize = true;
            this.lblTipoUer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUer.Location = new System.Drawing.Point(398, 21);
            this.lblTipoUer.Name = "lblTipoUer";
            this.lblTipoUer.Size = new System.Drawing.Size(74, 20);
            this.lblTipoUer.TabIndex = 5;
            this.lblTipoUer.Text = "Tipo user";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(497, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 33);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Llave Maestra";
            // 
            // tbLlaveMaestra
            // 
            this.tbLlaveMaestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLlaveMaestra.Location = new System.Drawing.Point(149, 20);
            this.tbLlaveMaestra.Name = "tbLlaveMaestra";
            this.tbLlaveMaestra.PasswordChar = '*';
            this.tbLlaveMaestra.Size = new System.Drawing.Size(383, 26);
            this.tbLlaveMaestra.TabIndex = 8;
            this.tbLlaveMaestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLlaveMaestra_KeyPress);
            // 
            // panelLlaveMaestra
            // 
            this.panelLlaveMaestra.Controls.Add(this.tbLlaveMaestra);
            this.panelLlaveMaestra.Controls.Add(this.label1);
            this.panelLlaveMaestra.Location = new System.Drawing.Point(38, 109);
            this.panelLlaveMaestra.Name = "panelLlaveMaestra";
            this.panelLlaveMaestra.Size = new System.Drawing.Size(553, 69);
            this.panelLlaveMaestra.TabIndex = 9;
            this.panelLlaveMaestra.Visible = false;
            // 
            // popupCambiarTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(615, 279);
            this.Controls.Add(this.panelLlaveMaestra);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTipoUer);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxTipoUsuario);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popupCambiarTipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popupCambiarTipoUsuario";
            this.Load += new System.EventHandler(this.popupCambiarTipoUsuario_Load);
            this.panelLlaveMaestra.ResumeLayout(false);
            this.panelLlaveMaestra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboxTipoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label lblTipoUer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLlaveMaestra;
        private System.Windows.Forms.Panel panelLlaveMaestra;
    }
}