
namespace Design_Dashboard_Modern.Vistas
{
    partial class popupBuscaProd
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
            this.btnVerCodigo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboxProductos = new System.Windows.Forms.ComboBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escriba el nombre del producto";
            // 
            // btnVerCodigo
            // 
            this.btnVerCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCodigo.Location = new System.Drawing.Point(234, 69);
            this.btnVerCodigo.Name = "btnVerCodigo";
            this.btnVerCodigo.Size = new System.Drawing.Size(126, 33);
            this.btnVerCodigo.TabIndex = 2;
            this.btnVerCodigo.Text = "Ver código";
            this.btnVerCodigo.UseVisualStyleBackColor = true;
            this.btnVerCodigo.Click += new System.EventHandler(this.btnVerCodigo_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(516, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboxProductos
            // 
            this.cboxProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProductos.FormattingEnabled = true;
            this.cboxProductos.Location = new System.Drawing.Point(245, 13);
            this.cboxProductos.Name = "cboxProductos";
            this.cboxProductos.Size = new System.Drawing.Size(517, 28);
            this.cboxProductos.TabIndex = 4;
            this.cboxProductos.SelectedIndexChanged += new System.EventHandler(this.cboxProductos_SelectedIndexChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(182, 123);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(448, 26);
            this.tbCodigo.TabIndex = 5;
            this.tbCodigo.Visible = false;
            // 
            // btnCopiar
            // 
            this.btnCopiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(636, 118);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(65, 36);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Visible = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // popupBuscaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(774, 171);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.cboxProductos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVerCodigo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "popupBuscaProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popupBuscaProd";
            this.Load += new System.EventHandler(this.popupBuscaProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerCodigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboxProductos;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnCopiar;
    }
}