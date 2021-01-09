namespace ADV_GalletasFO
{
    partial class FormCrudEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrudEmpleados));
            this.pnlOperaciones = new System.Windows.Forms.Panel();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRefreshEmploye = new System.Windows.Forms.Button();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.tbxRContraseña = new System.Windows.Forms.TextBox();
            this.tbxContraseña = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblRClave = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pbxEmploye = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.pnlOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOperaciones
            // 
            this.pnlOperaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOperaciones.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlOperaciones.Controls.Add(this.tbxId);
            this.pnlOperaciones.Controls.Add(this.btnModificar);
            this.pnlOperaciones.Controls.Add(this.btnRefreshEmploye);
            this.pnlOperaciones.Controls.Add(this.CbxTipo);
            this.pnlOperaciones.Controls.Add(this.tbxRContraseña);
            this.pnlOperaciones.Controls.Add(this.tbxContraseña);
            this.pnlOperaciones.Controls.Add(this.tbxUsuario);
            this.pnlOperaciones.Controls.Add(this.btnAgregar);
            this.pnlOperaciones.Controls.Add(this.lblRClave);
            this.pnlOperaciones.Controls.Add(this.lblClave);
            this.pnlOperaciones.Controls.Add(this.lblTipo);
            this.pnlOperaciones.Controls.Add(this.lblUsuario);
            this.pnlOperaciones.Controls.Add(this.tbxPath);
            this.pnlOperaciones.Controls.Add(this.btnExaminar);
            this.pnlOperaciones.Controls.Add(this.pbxEmploye);
            this.pnlOperaciones.Location = new System.Drawing.Point(221, 11);
            this.pnlOperaciones.Name = "pnlOperaciones";
            this.pnlOperaciones.Size = new System.Drawing.Size(534, 530);
            this.pnlOperaciones.TabIndex = 0;
            this.pnlOperaciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlOperaciones_MouseMove);
            // 
            // tbxId
            // 
            this.tbxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(332, 28);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(199, 32);
            this.tbxId.TabIndex = 17;
            this.tbxId.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(200, 448);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 39);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRefreshEmploye
            // 
            this.btnRefreshEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshEmploye.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRefreshEmploye.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnRefreshEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshEmploye.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshEmploye.Image")));
            this.btnRefreshEmploye.Location = new System.Drawing.Point(153, 108);
            this.btnRefreshEmploye.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshEmploye.Name = "btnRefreshEmploye";
            this.btnRefreshEmploye.Size = new System.Drawing.Size(44, 36);
            this.btnRefreshEmploye.TabIndex = 15;
            this.btnRefreshEmploye.UseVisualStyleBackColor = false;
            this.btnRefreshEmploye.Click += new System.EventHandler(this.btnRefreshEmploye_Click);
            // 
            // CbxTipo
            // 
            this.CbxTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "SECRETARIA",
            "ALMACEN"});
            this.CbxTipo.Location = new System.Drawing.Point(97, 252);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(358, 33);
            this.CbxTipo.TabIndex = 13;
            // 
            // tbxRContraseña
            // 
            this.tbxRContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxRContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRContraseña.Location = new System.Drawing.Point(97, 395);
            this.tbxRContraseña.Name = "tbxRContraseña";
            this.tbxRContraseña.PasswordChar = '*';
            this.tbxRContraseña.Size = new System.Drawing.Size(358, 32);
            this.tbxRContraseña.TabIndex = 12;
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContraseña.Location = new System.Drawing.Point(97, 323);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.PasswordChar = '*';
            this.tbxContraseña.Size = new System.Drawing.Size(358, 32);
            this.tbxContraseña.TabIndex = 11;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario.Location = new System.Drawing.Point(97, 180);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(358, 32);
            this.tbxUsuario.TabIndex = 9;
            this.tbxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsuario_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(200, 460);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 39);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblRClave
            // 
            this.lblRClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRClave.AutoSize = true;
            this.lblRClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRClave.Location = new System.Drawing.Point(93, 369);
            this.lblRClave.Name = "lblRClave";
            this.lblRClave.Size = new System.Drawing.Size(125, 23);
            this.lblRClave.TabIndex = 6;
            this.lblRClave.Text = "Contraseña";
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(93, 297);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(125, 23);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Contraseña";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(93, 226);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 23);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(93, 154);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 23);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // tbxPath
            // 
            this.tbxPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPath.Location = new System.Drawing.Point(332, 66);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(199, 32);
            this.tbxPath.TabIndex = 2;
            this.tbxPath.Visible = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExaminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(332, 102);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(146, 42);
            this.btnExaminar.TabIndex = 1;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pbxEmploye
            // 
            this.pbxEmploye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxEmploye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxEmploye.Location = new System.Drawing.Point(200, 3);
            this.pbxEmploye.Name = "pbxEmploye";
            this.pbxEmploye.Size = new System.Drawing.Size(126, 141);
            this.pbxEmploye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmploye.TabIndex = 0;
            this.pbxEmploye.TabStop = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btncerrar.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(870, 9);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(44, 36);
            this.btncerrar.TabIndex = 17;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // FormCrudEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(923, 553);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.pnlOperaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCrudEmpleados";
            this.Text = "Form1";
            this.pnlOperaciones.ResumeLayout(false);
            this.pnlOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmploye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperaciones;
        public System.Windows.Forms.TextBox tbxRContraseña;
        public System.Windows.Forms.TextBox tbxContraseña;
        public System.Windows.Forms.TextBox tbxUsuario;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblRClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.TextBox tbxPath;
        public System.Windows.Forms.Button btnExaminar;
        public System.Windows.Forms.PictureBox pbxEmploye;
        public System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.Button btnRefreshEmploye;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btncerrar;
        public System.Windows.Forms.TextBox tbxId;
    }
}