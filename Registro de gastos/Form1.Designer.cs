namespace Registro_de_gastos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGasto = new System.Windows.Forms.DataGridView();
            this.gbGestiónDeGastos = new System.Windows.Forms.GroupBox();
            this.lblTotalGasto = new System.Windows.Forms.Label();
            this.txtbTotalGasto = new System.Windows.Forms.TextBox();
            this.txtbNombreDelGasto = new System.Windows.Forms.TextBox();
            this.lblNombreDelGasto = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtbMonto = new System.Windows.Forms.TextBox();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.cbCategoría = new System.Windows.Forms.ComboBox();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoría = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.bttnCategoría = new System.Windows.Forms.Button();
            this.bttnConcepto = new System.Windows.Forms.Button();
            this.txtbCantidad = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasto)).BeginInit();
            this.gbGestiónDeGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGasto
            // 
            this.dgvGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGasto.Location = new System.Drawing.Point(378, 23);
            this.dgvGasto.Name = "dgvGasto";
            this.dgvGasto.RowHeadersWidth = 51;
            this.dgvGasto.RowTemplate.Height = 29;
            this.dgvGasto.Size = new System.Drawing.Size(586, 336);
            this.dgvGasto.TabIndex = 2;
            // 
            // gbGestiónDeGastos
            // 
            this.gbGestiónDeGastos.Controls.Add(this.lblTotalGasto);
            this.gbGestiónDeGastos.Controls.Add(this.txtbTotalGasto);
            this.gbGestiónDeGastos.Controls.Add(this.txtbNombreDelGasto);
            this.gbGestiónDeGastos.Controls.Add(this.lblNombreDelGasto);
            this.gbGestiónDeGastos.Controls.Add(this.lblMonto);
            this.gbGestiónDeGastos.Controls.Add(this.dgvGasto);
            this.gbGestiónDeGastos.Controls.Add(this.txtbMonto);
            this.gbGestiónDeGastos.Controls.Add(this.bttnGuardar);
            this.gbGestiónDeGastos.Controls.Add(this.lblID);
            this.gbGestiónDeGastos.Controls.Add(this.txtbID);
            this.gbGestiónDeGastos.Controls.Add(this.bttnBuscar);
            this.gbGestiónDeGastos.Controls.Add(this.bttnEliminar);
            this.gbGestiónDeGastos.Controls.Add(this.cbCategoría);
            this.gbGestiónDeGastos.Controls.Add(this.cbConcepto);
            this.gbGestiónDeGastos.Controls.Add(this.label4);
            this.gbGestiónDeGastos.Controls.Add(this.lblCategoría);
            this.gbGestiónDeGastos.Controls.Add(this.lblFecha);
            this.gbGestiónDeGastos.Controls.Add(this.lblConcepto);
            this.gbGestiónDeGastos.Controls.Add(this.bttnCategoría);
            this.gbGestiónDeGastos.Controls.Add(this.bttnConcepto);
            this.gbGestiónDeGastos.Controls.Add(this.txtbCantidad);
            this.gbGestiónDeGastos.Controls.Add(this.dtpFecha);
            this.gbGestiónDeGastos.Location = new System.Drawing.Point(12, 12);
            this.gbGestiónDeGastos.Name = "gbGestiónDeGastos";
            this.gbGestiónDeGastos.Size = new System.Drawing.Size(970, 365);
            this.gbGestiónDeGastos.TabIndex = 3;
            this.gbGestiónDeGastos.TabStop = false;
            this.gbGestiónDeGastos.Text = "Gestión de gastos";
            this.gbGestiónDeGastos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTotalGasto
            // 
            this.lblTotalGasto.AutoSize = true;
            this.lblTotalGasto.Location = new System.Drawing.Point(31, 335);
            this.lblTotalGasto.Name = "lblTotalGasto";
            this.lblTotalGasto.Size = new System.Drawing.Size(117, 20);
            this.lblTotalGasto.TabIndex = 40;
            this.lblTotalGasto.Text = "Total de gastos :";
            // 
            // txtbTotalGasto
            // 
            this.txtbTotalGasto.Enabled = false;
            this.txtbTotalGasto.Location = new System.Drawing.Point(154, 332);
            this.txtbTotalGasto.Name = "txtbTotalGasto";
            this.txtbTotalGasto.Size = new System.Drawing.Size(218, 27);
            this.txtbTotalGasto.TabIndex = 39;
            this.txtbTotalGasto.TextChanged += new System.EventHandler(this.txtbTotalGasto_TextChanged);
            // 
            // txtbNombreDelGasto
            // 
            this.txtbNombreDelGasto.Location = new System.Drawing.Point(24, 112);
            this.txtbNombreDelGasto.Name = "txtbNombreDelGasto";
            this.txtbNombreDelGasto.Size = new System.Drawing.Size(250, 27);
            this.txtbNombreDelGasto.TabIndex = 38;
            // 
            // lblNombreDelGasto
            // 
            this.lblNombreDelGasto.AutoSize = true;
            this.lblNombreDelGasto.Location = new System.Drawing.Point(24, 91);
            this.lblNombreDelGasto.Name = "lblNombreDelGasto";
            this.lblNombreDelGasto.Size = new System.Drawing.Size(137, 20);
            this.lblNombreDelGasto.TabIndex = 37;
            this.lblNombreDelGasto.Text = "Nombre del gasto :";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(47, 256);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(60, 20);
            this.lblMonto.TabIndex = 36;
            this.lblMonto.Text = "Monto :";
            // 
            // txtbMonto
            // 
            this.txtbMonto.Location = new System.Drawing.Point(111, 253);
            this.txtbMonto.Name = "txtbMonto";
            this.txtbMonto.Size = new System.Drawing.Size(163, 27);
            this.txtbMonto.TabIndex = 35;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.Lime;
            this.bttnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnGuardar.Location = new System.Drawing.Point(184, 286);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(90, 31);
            this.bttnGuardar.TabIndex = 30;
            this.bttnGuardar.Text = "GUARDAR/EDITAR";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(210, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 20);
            this.lblID.TabIndex = 34;
            this.lblID.Text = "ID :";
            // 
            // txtbID
            // 
            this.txtbID.Enabled = false;
            this.txtbID.Location = new System.Drawing.Point(247, 23);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(107, 27);
            this.txtbID.TabIndex = 33;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.LemonChiffon;
            this.bttnBuscar.Location = new System.Drawing.Point(280, 111);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(92, 29);
            this.bttnBuscar.TabIndex = 32;
            this.bttnBuscar.Text = "BUSCAR";
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.UseWaitCursor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.Red;
            this.bttnEliminar.Enabled = false;
            this.bttnEliminar.Location = new System.Drawing.Point(280, 286);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(92, 31);
            this.bttnEliminar.TabIndex = 31;
            this.bttnEliminar.Text = "ELIMINAR";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.UseWaitCursor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // cbCategoría
            // 
            this.cbCategoría.FormattingEnabled = true;
            this.cbCategoría.Location = new System.Drawing.Point(24, 219);
            this.cbCategoría.Name = "cbCategoría";
            this.cbCategoría.Size = new System.Drawing.Size(250, 28);
            this.cbCategoría.TabIndex = 13;
            this.cbCategoría.SelectedIndexChanged += new System.EventHandler(this.cbCategoría_SelectedIndexChanged);
            this.cbCategoría.Click += new System.EventHandler(this.cbCategoría_Click);
            // 
            // cbConcepto
            // 
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(24, 165);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(250, 28);
            this.cbConcepto.TabIndex = 12;
            this.cbConcepto.SelectedIndexChanged += new System.EventHandler(this.cbConcepto_SelectedIndexChanged);
            this.cbConcepto.Click += new System.EventHandler(this.cbConcepto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad :";
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Location = new System.Drawing.Point(20, 196);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(87, 20);
            this.lblCategoría.TabIndex = 10;
            this.lblCategoría.Text = "Categorías :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(24, 35);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha :";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(21, 142);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(86, 20);
            this.lblConcepto.TabIndex = 8;
            this.lblConcepto.Text = "Conceptos :";
            // 
            // bttnCategoría
            // 
            this.bttnCategoría.Location = new System.Drawing.Point(280, 219);
            this.bttnCategoría.Name = "bttnCategoría";
            this.bttnCategoría.Size = new System.Drawing.Size(92, 29);
            this.bttnCategoría.TabIndex = 6;
            this.bttnCategoría.Text = "...";
            this.bttnCategoría.UseVisualStyleBackColor = true;
            this.bttnCategoría.Click += new System.EventHandler(this.btnCategoría_Click);
            // 
            // bttnConcepto
            // 
            this.bttnConcepto.Location = new System.Drawing.Point(280, 164);
            this.bttnConcepto.Name = "bttnConcepto";
            this.bttnConcepto.Size = new System.Drawing.Size(92, 29);
            this.bttnConcepto.TabIndex = 5;
            this.bttnConcepto.Text = "...";
            this.bttnConcepto.UseVisualStyleBackColor = true;
            this.bttnConcepto.Click += new System.EventHandler(this.btnConcepto_Click);
            // 
            // txtbCantidad
            // 
            this.txtbCantidad.Location = new System.Drawing.Point(111, 290);
            this.txtbCantidad.Name = "txtbCantidad";
            this.txtbCantidad.Size = new System.Drawing.Size(69, 27);
            this.txtbCantidad.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(24, 61);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(250, 27);
            this.dtpFecha.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 381);
            this.Controls.Add(this.gbGestiónDeGastos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasto)).EndInit();
            this.gbGestiónDeGastos.ResumeLayout(false);
            this.gbGestiónDeGastos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvGasto;
        private GroupBox gbGestiónDeGastos;
        private Label label4;
        private Label lblCategoría;
        private Label lblFecha;
        private Label lblConcepto;
        private Button bttnCategoría;
        private Button bttnConcepto;
        private TextBox txtbCantidad;
        private DateTimePicker dtpFecha;
        private ComboBox cbCategoría;
        private ComboBox cbConcepto;
        private Label lblID;
        private Button bttnGuardar;
        private Button bttnBuscar;
        private Button bttnEliminar;
        private Label lblMonto;
        private TextBox txtbNombreDelGasto;
        private Label lblNombreDelGasto;
        private TextBox txtbMonto;
        private TextBox txtbID;
        private Label lblTotalGasto;
        private TextBox txtbTotalGasto;
    }
}