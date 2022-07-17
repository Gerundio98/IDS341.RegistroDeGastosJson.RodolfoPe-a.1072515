namespace Registro_de_gastos
{
    partial class Categoríacs
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
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.chbVisibilidad = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.lblDascripción = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.dgvCategoría = new System.Windows.Forms.DataGridView();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.gbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoría)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.Lime;
            this.bttnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnGuardar.Location = new System.Drawing.Point(316, 377);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(191, 49);
            this.bttnGuardar.TabIndex = 25;
            this.bttnGuardar.Text = "GUARDAR/EDITAR";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click_1);
            // 
            // gbPanel
            // 
            this.gbPanel.Controls.Add(this.bttnBuscar);
            this.gbPanel.Controls.Add(this.lblFecha);
            this.gbPanel.Controls.Add(this.chbVisibilidad);
            this.gbPanel.Controls.Add(this.lblID);
            this.gbPanel.Controls.Add(this.txtbID);
            this.gbPanel.Controls.Add(this.lblDascripción);
            this.gbPanel.Controls.Add(this.lblNombre);
            this.gbPanel.Controls.Add(this.txtbDescripcion);
            this.gbPanel.Controls.Add(this.txtbNombre);
            this.gbPanel.Location = new System.Drawing.Point(12, 31);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Size = new System.Drawing.Size(507, 340);
            this.gbPanel.TabIndex = 21;
            this.gbPanel.TabStop = false;
            this.gbPanel.Text = " Gestión de categorías";
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.LemonChiffon;
            this.bttnBuscar.Location = new System.Drawing.Point(327, 94);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(84, 29);
            this.bttnBuscar.TabIndex = 27;
            this.bttnBuscar.Text = "BUSCAR";
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.UseWaitCursor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(327, 308);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 20);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
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
            // lblDascripción
            // 
            this.lblDascripción.AutoSize = true;
            this.lblDascripción.Location = new System.Drawing.Point(15, 133);
            this.lblDascripción.Name = "lblDascripción";
            this.lblDascripción.Size = new System.Drawing.Size(87, 20);
            this.lblDascripción.TabIndex = 4;
            this.lblDascripción.Text = "Descripcion";
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
            // dgvCategoría
            // 
            this.dgvCategoría.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoría.Location = new System.Drawing.Point(525, 31);
            this.dgvCategoría.Name = "dgvCategoría";
            this.dgvCategoría.RowHeadersWidth = 51;
            this.dgvCategoría.RowTemplate.Height = 29;
            this.dgvCategoría.Size = new System.Drawing.Size(562, 395);
            this.dgvCategoría.TabIndex = 22;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnCancelar.Location = new System.Drawing.Point(20, 377);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(94, 49);
            this.bttnCancelar.TabIndex = 24;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.UseWaitCursor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.Red;
            this.bttnEliminar.Enabled = false;
            this.bttnEliminar.Location = new System.Drawing.Point(119, 377);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(191, 49);
            this.bttnEliminar.TabIndex = 26;
            this.bttnEliminar.Text = "ELIMINAR";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.UseWaitCursor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // Categoríacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 450);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.gbPanel);
            this.Controls.Add(this.dgvCategoría);
            this.Controls.Add(this.bttnCancelar);
            this.Name = "Categoríacs";
            this.Text = "Categoríacs";
            this.Load += new System.EventHandler(this.Categoríacs_Load);
            this.gbPanel.ResumeLayout(false);
            this.gbPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoría)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttnGuardar;
        private GroupBox gbPanel;
        private CheckBox chbVisibilidad;
        private Label lblID;
        private TextBox txtbID;
        private Label lblDascripción;
        private Label lblNombre;
        private TextBox txtbDescripcion;
        private TextBox txtbNombre;
        private DataGridView dgvCategoría;
        private Button bttnCancelar;
        private Button bttnNuevo;
        private Label lblFecha;
        private Button bttnBuscar;
        private Button bttnEliminar;
    }
}