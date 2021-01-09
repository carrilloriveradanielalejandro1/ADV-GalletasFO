namespace ADV_GalletasFO
{
    partial class FormCrudAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrudAlmacen));
            this.pnlOperaciones = new System.Windows.Forms.Panel();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tbxIdPro = new System.Windows.Forms.TextBox();
            this.cbxSstatus = new System.Windows.Forms.ComboBox();
            this.cbxCantPro = new System.Windows.Forms.ComboBox();
            this.cbxProductos = new System.Windows.Forms.ComboBox();
            this.tbxIdVendedor = new System.Windows.Forms.TextBox();
            this.cbxVendedores = new System.Windows.Forms.ComboBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.pnlOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperaciones
            // 
            this.pnlOperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOperaciones.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlOperaciones.Controls.Add(this.tbxID);
            this.pnlOperaciones.Controls.Add(this.btnEditar);
            this.pnlOperaciones.Controls.Add(this.label4);
            this.pnlOperaciones.Controls.Add(this.label3);
            this.pnlOperaciones.Controls.Add(this.label2);
            this.pnlOperaciones.Controls.Add(this.label1);
            this.pnlOperaciones.Controls.Add(this.btnCargar);
            this.pnlOperaciones.Controls.Add(this.tbxIdPro);
            this.pnlOperaciones.Controls.Add(this.cbxSstatus);
            this.pnlOperaciones.Controls.Add(this.cbxCantPro);
            this.pnlOperaciones.Controls.Add(this.cbxProductos);
            this.pnlOperaciones.Controls.Add(this.tbxIdVendedor);
            this.pnlOperaciones.Controls.Add(this.cbxVendedores);
            this.pnlOperaciones.Location = new System.Drawing.Point(95, 12);
            this.pnlOperaciones.Name = "pnlOperaciones";
            this.pnlOperaciones.Size = new System.Drawing.Size(436, 428);
            this.pnlOperaciones.TabIndex = 0;
            this.pnlOperaciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlOperaciones_MouseMove);
            // 
            // tbxID
            // 
            this.tbxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(66, 53);
            this.tbxID.Name = "tbxID";
            this.tbxID.ReadOnly = true;
            this.tbxID.Size = new System.Drawing.Size(80, 28);
            this.tbxID.TabIndex = 13;
            this.tbxID.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(166, 337);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 40);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "EDTAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad Status";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Asignación";
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(166, 356);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(114, 40);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tbxIdPro
            // 
            this.tbxIdPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxIdPro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdPro.Location = new System.Drawing.Point(63, 187);
            this.tbxIdPro.Name = "tbxIdPro";
            this.tbxIdPro.ReadOnly = true;
            this.tbxIdPro.Size = new System.Drawing.Size(80, 28);
            this.tbxIdPro.TabIndex = 6;
            // 
            // cbxSstatus
            // 
            this.cbxSstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSstatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSstatus.FormattingEnabled = true;
            this.cbxSstatus.Items.AddRange(new object[] {
            "ENTRADA",
            "SALIDA"});
            this.cbxSstatus.Location = new System.Drawing.Point(149, 261);
            this.cbxSstatus.Name = "cbxSstatus";
            this.cbxSstatus.Size = new System.Drawing.Size(208, 29);
            this.cbxSstatus.TabIndex = 5;
            this.cbxSstatus.Click += new System.EventHandler(this.cbxSstatus_Click);
            // 
            // cbxCantPro
            // 
            this.cbxCantPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCantPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCantPro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCantPro.FormattingEnabled = true;
            this.cbxCantPro.Location = new System.Drawing.Point(63, 261);
            this.cbxCantPro.Name = "cbxCantPro";
            this.cbxCantPro.Size = new System.Drawing.Size(80, 29);
            this.cbxCantPro.TabIndex = 4;
            this.cbxCantPro.Click += new System.EventHandler(this.cbxCantPro_Click);
            // 
            // cbxProductos
            // 
            this.cbxProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxProductos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(149, 187);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(281, 29);
            this.cbxProductos.TabIndex = 2;
            this.cbxProductos.Click += new System.EventHandler(this.cbxProductos_Click);
            // 
            // tbxIdVendedor
            // 
            this.tbxIdVendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxIdVendedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdVendedor.Location = new System.Drawing.Point(63, 108);
            this.tbxIdVendedor.Name = "tbxIdVendedor";
            this.tbxIdVendedor.ReadOnly = true;
            this.tbxIdVendedor.Size = new System.Drawing.Size(80, 28);
            this.tbxIdVendedor.TabIndex = 1;
            // 
            // cbxVendedores
            // 
            this.cbxVendedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVendedores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVendedores.FormattingEnabled = true;
            this.cbxVendedores.Location = new System.Drawing.Point(149, 106);
            this.cbxVendedores.Name = "cbxVendedores";
            this.cbxVendedores.Size = new System.Drawing.Size(281, 29);
            this.cbxVendedores.TabIndex = 0;
            this.cbxVendedores.Click += new System.EventHandler(this.cbxVendedores_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btncerrar.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(565, 9);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(44, 36);
            this.btncerrar.TabIndex = 18;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // FormCrudAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(618, 452);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.pnlOperaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCrudAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCrudAlmacen";
            this.pnlOperaciones.ResumeLayout(false);
            this.pnlOperaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperaciones;
        public System.Windows.Forms.ComboBox cbxVendedores;
        public System.Windows.Forms.TextBox tbxIdVendedor;
        public System.Windows.Forms.Button btncerrar;
        public System.Windows.Forms.ComboBox cbxCantPro;
        public System.Windows.Forms.ComboBox cbxProductos;
        public System.Windows.Forms.ComboBox cbxSstatus;
        public System.Windows.Forms.TextBox tbxIdPro;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.TextBox tbxID;
    }
}