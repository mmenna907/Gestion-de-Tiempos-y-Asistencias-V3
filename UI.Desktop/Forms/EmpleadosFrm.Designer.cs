namespace UI.Desktop.Forms
{
    partial class EmpleadosFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosFrm));
            this.gridEmpleados = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.lblCancelarEdicion = new System.Windows.Forms.Label();
            this.comboSeccion = new System.Windows.Forms.ComboBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblContraseñaMarcacion = new System.Windows.Forms.Label();
            this.txtContraseñaMarcacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarjetaRFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmpleados.BackgroundColor = System.Drawing.Color.Silver;
            this.gridEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEmpleados.ColumnHeadersHeight = 30;
            this.gridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridEmpleados.EnableHeadersVisualStyles = false;
            this.gridEmpleados.Location = new System.Drawing.Point(12, 102);
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.ReadOnly = true;
            this.gridEmpleados.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmpleados.Size = new System.Drawing.Size(1019, 462);
            this.gridEmpleados.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(12, 65);
            this.txtBuscar.MaxLength = 100;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(1019, 26);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.Text = "Buscar...";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.picCerrar);
            this.panelTop.Controls.Add(this.btnAgregar);
            this.panelTop.Controls.Add(this.btnEliminar);
            this.panelTop.Controls.Add(this.btnModificar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 50);
            this.panelTop.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1079, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "EMPLEADOS";
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(1267, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(30, 27);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCerrar.TabIndex = 12;
            this.picCerrar.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(107)))), ((int)(((byte)(170)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(5, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(107)))), ((int)(((byte)(170)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(246, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(129, 7);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Editar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            this.panelLateral.Controls.Add(this.lblCancelarEdicion);
            this.panelLateral.Controls.Add(this.comboSeccion);
            this.panelLateral.Controls.Add(this.lblSeccion);
            this.panelLateral.Controls.Add(this.btnGuardar);
            this.panelLateral.Controls.Add(this.label4);
            this.panelLateral.Controls.Add(this.lblContraseñaMarcacion);
            this.panelLateral.Controls.Add(this.txtContraseñaMarcacion);
            this.panelLateral.Controls.Add(this.label2);
            this.panelLateral.Controls.Add(this.txtTarjetaRFID);
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.txtNombre);
            this.panelLateral.Controls.Add(this.lblLegajo);
            this.panelLateral.Controls.Add(this.txtLegajo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateral.Location = new System.Drawing.Point(1037, 50);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(263, 526);
            this.panelLateral.TabIndex = 16;
            // 
            // lblCancelarEdicion
            // 
            this.lblCancelarEdicion.AutoSize = true;
            this.lblCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelarEdicion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarEdicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.lblCancelarEdicion.Location = new System.Drawing.Point(109, 430);
            this.lblCancelarEdicion.Name = "lblCancelarEdicion";
            this.lblCancelarEdicion.Size = new System.Drawing.Size(74, 19);
            this.lblCancelarEdicion.TabIndex = 15;
            this.lblCancelarEdicion.Text = "Cancelar";
            // 
            // comboSeccion
            // 
            this.comboSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSeccion.FormattingEnabled = true;
            this.comboSeccion.Location = new System.Drawing.Point(50, 328);
            this.comboSeccion.Name = "comboSeccion";
            this.comboSeccion.Size = new System.Drawing.Size(206, 28);
            this.comboSeccion.TabIndex = 14;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.ForeColor = System.Drawing.Color.White;
            this.lblSeccion.Location = new System.Drawing.Point(16, 304);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(75, 21);
            this.lblSeccion.TabIndex = 13;
            this.lblSeccion.Text = "Seccion:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(20, 375);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(233, 41);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agregar / Editar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContraseñaMarcacion
            // 
            this.lblContraseñaMarcacion.AutoSize = true;
            this.lblContraseñaMarcacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaMarcacion.ForeColor = System.Drawing.Color.White;
            this.lblContraseñaMarcacion.Location = new System.Drawing.Point(16, 244);
            this.lblContraseñaMarcacion.Name = "lblContraseñaMarcacion";
            this.lblContraseñaMarcacion.Size = new System.Drawing.Size(196, 21);
            this.lblContraseñaMarcacion.TabIndex = 7;
            this.lblContraseñaMarcacion.Text = "Contraseña Marcacion:";
            // 
            // txtContraseñaMarcacion
            // 
            this.txtContraseñaMarcacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaMarcacion.Location = new System.Drawing.Point(50, 269);
            this.txtContraseñaMarcacion.Name = "txtContraseñaMarcacion";
            this.txtContraseñaMarcacion.Size = new System.Drawing.Size(206, 26);
            this.txtContraseñaMarcacion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "N° de Tarjeta RFID:";
            // 
            // txtTarjetaRFID
            // 
            this.txtTarjetaRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjetaRFID.Location = new System.Drawing.Point(50, 211);
            this.txtTarjetaRFID.Name = "txtTarjetaRFID";
            this.txtTarjetaRFID.Size = new System.Drawing.Size(206, 26);
            this.txtTarjetaRFID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(50, 151);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.White;
            this.lblLegajo.Location = new System.Drawing.Point(16, 69);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(66, 21);
            this.lblLegajo.TabIndex = 1;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.Location = new System.Drawing.Point(50, 94);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(203, 26);
            this.txtLegajo.TabIndex = 0;
            // 
            // EmpleadosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 576);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.gridEmpleados);
            this.Name = "EmpleadosFrm";
            this.Tag = "algo";
            this.Text = "EmpleadosFrm";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblContraseñaMarcacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel panelLateral;
        public System.Windows.Forms.DataGridView gridEmpleados;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.PictureBox picCerrar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtContraseñaMarcacion;
        public System.Windows.Forms.TextBox txtTarjetaRFID;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtLegajo;
        public System.Windows.Forms.ComboBox comboSeccion;
        public System.Windows.Forms.Label lblCancelarEdicion;
    }
}