namespace Registro_de_gastos
{
    partial class Concepto
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
            this.gbConcepto = new System.Windows.Forms.GroupBox();
            this.chbVisibilidad = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.dgvConcepto = new System.Windows.Forms.DataGridView();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.gbConcepto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcepto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConcepto
            // 
            this.gbConcepto.Controls.Add(this.chbVisibilidad);
            this.gbConcepto.Controls.Add(this.lblID);
            this.gbConcepto.Controls.Add(this.txtbID);
            this.gbConcepto.Controls.Add(this.lblFecha);
            this.gbConcepto.Controls.Add(this.lblDescripción);
            this.gbConcepto.Controls.Add(this.lblNombre);
            this.gbConcepto.Controls.Add(this.txtbDescripcion);
            this.gbConcepto.Controls.Add(this.txtbNombre);
            this.gbConcepto.Location = new System.Drawing.Point(12, 12);
            this.gbConcepto.Name = "gbConcepto";
            this.gbConcepto.Size = new System.Drawing.Size(507, 340);
            this.gbConcepto.TabIndex = 1;
            this.gbConcepto.TabStop = false;
            this.gbConcepto.Text = "Gestión de conceptos";
            // 
            // chbVisibilidad
            // 
            this.chbVisibilidad.AutoSize = true;
            this.chbVisibilidad.Location = new System.Drawing.Point(17, 304);
            this.chbVisibilidad.Name = "chbVisibilidad";
            this.chbVisibilidad.Size = new System.Drawing.Size(145, 24);
            this.chbVisibilidad.TabIndex = 9;
            this.chbVisibilidad.Text = "Visible al publico";
            this.chbVisibilidad.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(477, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 20);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // txtbID
            // 
            this.txtbID.Enabled = false;
            this.txtbID.Location = new System.Drawing.Point(376, 49);
            this.txtbID.Name = "txtbID";
            this.txtbID.ReadOnly = true;
            this.txtbID.Size = new System.Drawing.Size(125, 27);
            this.txtbID.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(330, 305);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 20);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.lblCreatedDate_Click);
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Location = new System.Drawing.Point(15, 133);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(87, 20);
            this.lblDescripción.TabIndex = 4;
            this.lblDescripción.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(15, 156);
            this.txtbDescripcion.Multiline = true;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(476, 139);
            this.txtbDescripcion.TabIndex = 1;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(15, 94);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(300, 27);
            this.txtbNombre.TabIndex = 0;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.Lime;
            this.bttnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnGuardar.Location = new System.Drawing.Point(127, 358);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(191, 72);
            this.bttnGuardar.TabIndex = 20;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvConcepto
            // 
            this.dgvConcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcepto.Location = new System.Drawing.Point(525, 35);
            this.dgvConcepto.Name = "dgvConcepto";
            this.dgvConcepto.RowHeadersWidth = 51;
            this.dgvConcepto.RowTemplate.Height = 29;
            this.dgvConcepto.Size = new System.Drawing.Size(562, 395);
            this.dgvConcepto.TabIndex = 17;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnCancelar.Location = new System.Drawing.Point(12, 358);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(109, 72);
            this.bttnCancelar.TabIndex = 19;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.Red;
            this.bttnEliminar.Enabled = false;
            this.bttnEliminar.Location = new System.Drawing.Point(328, 358);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(191, 72);
            this.bttnEliminar.TabIndex = 28;
            this.bttnEliminar.Text = "ELIMINAR";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.UseWaitCursor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.LemonChiffon;
            this.bttnBuscar.Location = new System.Drawing.Point(342, 104);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(84, 29);
            this.bttnBuscar.TabIndex = 29;
            this.bttnBuscar.Text = "BUSCAR";
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.UseWaitCursor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // Concepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.gbConcepto);
            this.Controls.Add(this.dgvConcepto);
            this.Controls.Add(this.bttnCancelar);
            this.Name = "Concepto";
            this.Text = "Concepto";
            this.gbConcepto.ResumeLayout(false);
            this.gbConcepto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcepto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbConcepto;
        private CheckBox chbVisibilidad;
        private Label lblID;
        private TextBox txtbID;
        private Label lblFecha;
        private Label lblDescripción;
        private Label lblNombre;
        private TextBox txtbDescripcion;
        private TextBox txtbNombre;
        private Button bttnGuardar;
        private DataGridView dgvConcepto;
        private Button bttnCancelar;
        private Button bttnNuevo;
        private Button bttnEliminar;
        private Button bttnBuscar;
    }
}