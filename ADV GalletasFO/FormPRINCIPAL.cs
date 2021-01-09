using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADV_GalletasFO
{
    public partial class frmPrincipal : Form
    {
        public int xClick = 0, yClick = 0;

        public frmPrincipal()
        {
            InitializeComponent();
            openEmploye(new FormEmpleados());
        }

        public void openEmploye(object frmEmploye)
        {
            if (this.pnlOperaciones.Controls.Count > 0)
                this.pnlOperaciones.Controls.RemoveAt(0);
            Form employe = frmEmploye as Form;
            employe.TopLevel = false;
            employe.Dock = DockStyle.Fill;
            this.pnlOperaciones.Controls.Add(employe);
            this.pnlOperaciones.Tag = employe;
            employe.Show();
        }

        public void openCrudEmploye(object frmCrudEmploye)
        {
            if (this.pnlOperaciones.Controls.Count > 0)
                this.pnlOperaciones.Controls.RemoveAt(0);
            Form employeCrud = frmCrudEmploye as Form;
            employeCrud.TopLevel = false;
            employeCrud.Dock = DockStyle.Fill;
            this.pnlOperaciones.Controls.Add(employeCrud);
            this.pnlOperaciones.Tag = employeCrud;
            employeCrud.Show();
        }

        public void openwarehouse(object frmAlmacen)
        {
            if (this.pnlOperaciones.Controls.Count > 0)
                this.pnlOperaciones.Controls.RemoveAt(0);
            Form almacen = frmAlmacen as Form;
            almacen.TopLevel = false;
            almacen.Dock = DockStyle.Fill;
            this.pnlOperaciones.Controls.Add(almacen);
            this.pnlOperaciones.Tag = almacen;
            almacen.Show();
        }

        public void openProducts(object frmProductos)
        {
            if (this.pnlOperaciones.Controls.Count > 0)
                this.pnlOperaciones.Controls.RemoveAt(0);
            Form productos = frmProductos as Form;
            productos.TopLevel = false;
            productos.Dock = DockStyle.Fill;
            this.pnlOperaciones.Controls.Add(productos);
            this.pnlOperaciones.Tag = productos;
            productos.Show();
        }

        public void openCarga(object frmCargaTotal)
        {
            if (this.pnlOperaciones.Controls.Count > 0)
                this.pnlOperaciones.Controls.RemoveAt(0);
            Form CargaTotal = frmCargaTotal as Form;
            CargaTotal.TopLevel = false;
            CargaTotal.Dock = DockStyle.Fill;
            this.pnlOperaciones.Controls.Add(CargaTotal);
            this.pnlOperaciones.Tag = CargaTotal;
            CargaTotal.Show();
        }

        public void openventas(object frmVentadia)
        {
            if (this.pnlOperaciones.Controls.Count > 0)
                this.pnlOperaciones.Controls.RemoveAt(0);
            Form Ventadia = frmVentadia as Form;
            Ventadia.TopLevel = false;
            Ventadia.Dock = DockStyle.Fill;
            this.pnlOperaciones.Controls.Add(Ventadia);
            this.pnlOperaciones.Tag = Ventadia;
            Ventadia.Show();
        }

        public void openNomina(object frmNomina)
        {
            if (this.pnlOperaciones.Controls.Count > 0)
                this.pnlOperaciones.Controls.RemoveAt(0);
            Form Nomina = frmNomina as Form;
            Nomina.TopLevel = false;
            Nomina.Dock = DockStyle.Fill;
            this.pnlOperaciones.Controls.Add(Nomina);
            this.pnlOperaciones.Tag = Nomina;
            Nomina.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Deseas abandonar el programa?";
            String advertencia = "CERRAR";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult resultado = MessageBox.Show( mensaje, advertencia, buttons , icon);
            
            if(resultado == System.Windows.Forms.DialogResult.Yes)
                Application.Exit(); 
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            else if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCmbiarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            formIngreso inicio = new formIngreso();
            inicio.Show();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            openEmploye(new FormEmpleados());
        }

        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrudEmpleados employe = new FormCrudEmpleados();
            employe.btncerrar.Visible = false;
            employe.btnModificar.Visible = false;
            openCrudEmploye(employe);
        }

        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openProducts(new FormProductos());
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            openCarga(new FormCargaTotal());
        }

        private void btnCarga_Click_1(object sender, EventArgs e)
        {
            openCarga(new FormCargaTotal());
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            openventas(new FormVentadia());
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            openNomina(new FormNomina());
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            openwarehouse(new FormAlmacen());
        }
    }
}
