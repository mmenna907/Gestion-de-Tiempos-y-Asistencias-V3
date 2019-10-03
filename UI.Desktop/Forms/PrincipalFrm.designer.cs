namespace UI.Desktop.Forms
{
    partial class PrincipalFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFrm));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pictureMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureCerrar = new System.Windows.Forms.PictureBox();
            this.pictureMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureRestaurar = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnUsuariosDelSistema = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnDispositivos = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestaurar)).BeginInit();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelCentral);
            this.panelContenedor.Controls.Add(this.panelInferior);
            this.panelContenedor.Controls.Add(this.panelSuperior);
            this.panelContenedor.Controls.Add(this.panelLateral);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.MinimumSize = new System.Drawing.Size(1000, 400);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1500, 650);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelCentral
            // 
            this.panelCentral.Location = new System.Drawing.Point(290, 29);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1316, 615);
            this.panelCentral.TabIndex = 3;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.LightGray;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(284, 604);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1216, 46);
            this.panelInferior.TabIndex = 2;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Gray;
            this.panelSuperior.Controls.Add(this.btnUsuario);
            this.panelSuperior.Controls.Add(this.pictureMaximizar);
            this.panelSuperior.Controls.Add(this.pictureCerrar);
            this.panelSuperior.Controls.Add(this.pictureMinimizar);
            this.panelSuperior.Controls.Add(this.pictureRestaurar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(284, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1216, 26);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PrincipalFrm_MouseDown);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.Location = new System.Drawing.Point(957, 0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(184, 26);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // pictureMaximizar
            // 
            this.pictureMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureMaximizar.Image")));
            this.pictureMaximizar.Location = new System.Drawing.Point(1171, 3);
            this.pictureMaximizar.Name = "pictureMaximizar";
            this.pictureMaximizar.Size = new System.Drawing.Size(20, 20);
            this.pictureMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureMaximizar.TabIndex = 0;
            this.pictureMaximizar.TabStop = false;
            // 
            // pictureCerrar
            // 
            this.pictureCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureCerrar.Image")));
            this.pictureCerrar.Location = new System.Drawing.Point(1193, 3);
            this.pictureCerrar.Name = "pictureCerrar";
            this.pictureCerrar.Size = new System.Drawing.Size(20, 20);
            this.pictureCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCerrar.TabIndex = 1;
            this.pictureCerrar.TabStop = false;
            // 
            // pictureMinimizar
            // 
            this.pictureMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimizar.Image")));
            this.pictureMinimizar.Location = new System.Drawing.Point(1146, 3);
            this.pictureMinimizar.Name = "pictureMinimizar";
            this.pictureMinimizar.Size = new System.Drawing.Size(20, 20);
            this.pictureMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureMinimizar.TabIndex = 0;
            this.pictureMinimizar.TabStop = false;
            // 
            // pictureRestaurar
            // 
            this.pictureRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictureRestaurar.Image")));
            this.pictureRestaurar.Location = new System.Drawing.Point(1170, 3);
            this.pictureRestaurar.Name = "pictureRestaurar";
            this.pictureRestaurar.Size = new System.Drawing.Size(20, 20);
            this.pictureRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureRestaurar.TabIndex = 2;
            this.pictureRestaurar.TabStop = false;
            this.pictureRestaurar.Visible = false;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Gray;
            this.panelLateral.Controls.Add(this.btnUsuariosDelSistema);
            this.panelLateral.Controls.Add(this.btnEmpleados);
            this.panelLateral.Controls.Add(this.btnReportes);
            this.panelLateral.Controls.Add(this.btnDispositivos);
            this.panelLateral.Controls.Add(this.pictureLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(284, 650);
            this.panelLateral.TabIndex = 0;
            // 
            // btnUsuariosDelSistema
            // 
            this.btnUsuariosDelSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            this.btnUsuariosDelSistema.FlatAppearance.BorderSize = 0;
            this.btnUsuariosDelSistema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnUsuariosDelSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnUsuariosDelSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosDelSistema.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosDelSistema.ForeColor = System.Drawing.Color.White;
            this.btnUsuariosDelSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuariosDelSistema.Image")));
            this.btnUsuariosDelSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuariosDelSistema.Location = new System.Drawing.Point(0, 215);
            this.btnUsuariosDelSistema.Name = "btnUsuariosDelSistema";
            this.btnUsuariosDelSistema.Size = new System.Drawing.Size(282, 41);
            this.btnUsuariosDelSistema.TabIndex = 11;
            this.btnUsuariosDelSistema.Text = "Usuarios del sistema";
            this.btnUsuariosDelSistema.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 119);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(282, 41);
            this.btnEmpleados.TabIndex = 10;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 263);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(282, 41);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Visible = false;
            // 
            // btnDispositivos
            // 
            this.btnDispositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            this.btnDispositivos.FlatAppearance.BorderSize = 0;
            this.btnDispositivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btnDispositivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnDispositivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispositivos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivos.ForeColor = System.Drawing.Color.White;
            this.btnDispositivos.Image = ((System.Drawing.Image)(resources.GetObject("btnDispositivos.Image")));
            this.btnDispositivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDispositivos.Location = new System.Drawing.Point(0, 167);
            this.btnDispositivos.Name = "btnDispositivos";
            this.btnDispositivos.Size = new System.Drawing.Size(282, 41);
            this.btnDispositivos.TabIndex = 8;
            this.btnDispositivos.Text = "Dispositivos";
            this.btnDispositivos.UseVisualStyleBackColor = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(282, 83);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 3;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PrincipalFrm_MouseDown);
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "PrincipalFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalFrm";
            this.panelContenedor.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestaurar)).EndInit();
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureLogo;
        public System.Windows.Forms.Panel panelInferior;
        public System.Windows.Forms.Panel panelSuperior;
        public System.Windows.Forms.Panel panelLateral;
        public System.Windows.Forms.Panel panelCentral;
        public System.Windows.Forms.PictureBox pictureMaximizar;
        public System.Windows.Forms.PictureBox pictureCerrar;
        public System.Windows.Forms.PictureBox pictureMinimizar;
        public System.Windows.Forms.Button btnUsuario;
        public System.Windows.Forms.Button btnUsuariosDelSistema;
        public System.Windows.Forms.Button btnEmpleados;
        public System.Windows.Forms.Button btnReportes;
        public System.Windows.Forms.Button btnDispositivos;
        public System.Windows.Forms.Panel panelContenedor;
        public System.Windows.Forms.PictureBox pictureRestaurar;
    }
}