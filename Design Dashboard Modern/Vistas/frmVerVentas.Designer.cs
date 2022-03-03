
namespace Design_Dashboard_Modern.Vistas
{
    partial class frmVerVentas
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
            this.dgvVerVentas = new System.Windows.Forms.DataGridView();
            this.btnVentasDia = new System.Windows.Forms.Button();
            this.btnVentasSemana = new System.Windows.Forms.Button();
            this.btnVentasMes = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboxFiltros = new System.Windows.Forms.ComboBox();
            this.btnReimprimir = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.panCrud = new System.Windows.Forms.Panel();
            this.dtpFiltro = new System.Windows.Forms.DateTimePicker();
            this.btnVerTodas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerVentas)).BeginInit();
            this.panCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerVentas
            // 
            this.dgvVerVentas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvVerVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVerVentas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVerVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerVentas.Location = new System.Drawing.Point(0, 320);
            this.dgvVerVentas.MultiSelect = false;
            this.dgvVerVentas.Name = "dgvVerVentas";
            this.dgvVerVentas.ReadOnly = true;
            this.dgvVerVentas.RowHeadersVisible = false;
            this.dgvVerVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVerVentas.RowTemplate.ReadOnly = true;
            this.dgvVerVentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerVentas.Size = new System.Drawing.Size(786, 429);
            this.dgvVerVentas.TabIndex = 0;
            this.dgvVerVentas.TabStop = false;
            // 
            // btnVentasDia
            // 
            this.btnVentasDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasDia.Location = new System.Drawing.Point(12, 114);
            this.btnVentasDia.Name = "btnVentasDia";
            this.btnVentasDia.Size = new System.Drawing.Size(174, 35);
            this.btnVentasDia.TabIndex = 1;
            this.btnVentasDia.Text = "ventas del día";
            this.btnVentasDia.UseVisualStyleBackColor = true;
            this.btnVentasDia.Click += new System.EventHandler(this.btnVentasDia_Click);
            // 
            // btnVentasSemana
            // 
            this.btnVentasSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasSemana.Location = new System.Drawing.Point(12, 156);
            this.btnVentasSemana.Name = "btnVentasSemana";
            this.btnVentasSemana.Size = new System.Drawing.Size(174, 35);
            this.btnVentasSemana.TabIndex = 2;
            this.btnVentasSemana.Text = "ventas de la semana";
            this.btnVentasSemana.UseVisualStyleBackColor = true;
            this.btnVentasSemana.Click += new System.EventHandler(this.btnVentasSemana_Click);
            // 
            // btnVentasMes
            // 
            this.btnVentasMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasMes.Location = new System.Drawing.Point(12, 198);
            this.btnVentasMes.Name = "btnVentasMes";
            this.btnVentasMes.Size = new System.Drawing.Size(174, 35);
            this.btnVentasMes.TabIndex = 4;
            this.btnVentasMes.Text = "ventas del mes";
            this.btnVentasMes.UseVisualStyleBackColor = true;
            this.btnVentasMes.Click += new System.EventHandler(this.btnVentasMes_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(410, 38);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(312, 26);
            this.tbFiltro.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(743, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 35);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "buscar venta";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cboxFiltros
            // 
            this.cboxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFiltros.FormattingEnabled = true;
            this.cboxFiltros.Items.AddRange(new object[] {
            "Fecha",
            "Producto",
            "Vendedor",
            "Comprobante",
            "Cliente"});
            this.cboxFiltros.Location = new System.Drawing.Point(253, 38);
            this.cboxFiltros.Name = "cboxFiltros";
            this.cboxFiltros.Size = new System.Drawing.Size(151, 28);
            this.cboxFiltros.TabIndex = 7;
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimir.Location = new System.Drawing.Point(13, 7);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(273, 35);
            this.btnReimprimir.TabIndex = 10;
            this.btnReimprimir.Text = "reimprimir comprobante de venta";
            this.btnReimprimir.UseVisualStyleBackColor = true;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.Location = new System.Drawing.Point(13, 91);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(273, 35);
            this.btnVerDetalle.TabIndex = 9;
            this.btnVerDetalle.Text = "ver detalle de esta venta";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(13, 49);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(273, 35);
            this.btnAnular.TabIndex = 8;
            this.btnAnular.Text = "anular esta venta";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // panCrud
            // 
            this.panCrud.Controls.Add(this.btnReimprimir);
            this.panCrud.Controls.Add(this.btnAnular);
            this.panCrud.Controls.Add(this.btnVerDetalle);
            this.panCrud.Location = new System.Drawing.Point(414, 102);
            this.panCrud.Name = "panCrud";
            this.panCrud.Size = new System.Drawing.Size(308, 131);
            this.panCrud.TabIndex = 11;
            // 
            // dtpFiltro
            // 
            this.dtpFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltro.Location = new System.Drawing.Point(410, 70);
            this.dtpFiltro.Name = "dtpFiltro";
            this.dtpFiltro.Size = new System.Drawing.Size(312, 26);
            this.dtpFiltro.TabIndex = 12;
            this.dtpFiltro.Visible = false;
            // 
            // btnVerTodas
            // 
            this.btnVerTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodas.Location = new System.Drawing.Point(12, 12);
            this.btnVerTodas.Name = "btnVerTodas";
            this.btnVerTodas.Size = new System.Drawing.Size(174, 35);
            this.btnVerTodas.TabIndex = 13;
            this.btnVerTodas.Text = "ver todas las ventas";
            this.btnVerTodas.UseVisualStyleBackColor = true;
            this.btnVerTodas.Click += new System.EventHandler(this.btnVerTodas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccione un filtro de búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seleccione una venta del siguiente listado para ver las opciones";
            // 
            // frmVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerTodas);
            this.Controls.Add(this.dtpFiltro);
            this.Controls.Add(this.panCrud);
            this.Controls.Add(this.cboxFiltros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.btnVentasMes);
            this.Controls.Add(this.btnVentasSemana);
            this.Controls.Add(this.btnVentasDia);
            this.Controls.Add(this.dgvVerVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerVentas";
            this.Text = "frmVerVentas";
            this.Load += new System.EventHandler(this.frmVerVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerVentas)).EndInit();
            this.panCrud.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerVentas;
        private System.Windows.Forms.Button btnVentasDia;
        private System.Windows.Forms.Button btnVentasSemana;
        private System.Windows.Forms.Button btnVentasMes;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboxFiltros;
        private System.Windows.Forms.Button btnReimprimir;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Panel panCrud;
        private System.Windows.Forms.DateTimePicker dtpFiltro;
        private System.Windows.Forms.Button btnVerTodas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}