using MySql.Data.MySqlClient;
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
    public partial class FormCrudEmpleados : Form
    {
        String connectionString = "Server=127.0.0.1;Port=3306;Database=gfoventas;Uid=gfoAdmin;Pwd=G.F.O.*2020Vts;";
        OpenFileDialog imagen = new OpenFileDialog();

        public int xClick = 0, yClick = 0;

        public FormCrudEmpleados()
        {
            InitializeComponent();
            if (CbxTipo.Items.Count > 0)
                CbxTipo.SelectedIndex = 0;

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            imagen.InitialDirectory = "C:\\";
            imagen.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                pbxEmploye.ImageLocation = imagen.FileName;
                tbxPath.Text = imagen.FileName.Replace("\\", "\\\\");

            }
        }
        public void clearEmployeRegistry()
        {
            if (pbxEmploye.Image != null)
            {
                pbxEmploye.Image.Dispose();
                pbxEmploye.Image = null;
            }
            tbxPath.Clear();
            tbxUsuario.Clear();
            tbxContraseña.Clear();
            tbxRContraseña.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text.Equals("") || CbxTipo.Text.Equals("") || 
                tbxContraseña.Text.Equals("") || tbxRContraseña.Text.Equals(""))
            {
                MessageBox.Show("Completa los Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tbxContraseña.Text.Equals(tbxRContraseña.Text))
                {

                    if (tbxPath.Text.Equals(""))
                    {
                        DialogResult resultado = MessageBox.Show("¿Deseas guardar sin foto?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (DialogResult.Yes == resultado)
                        {
                            try
                            {
                                MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                                conexionMysql.Open();
                                string consulta_query = "INSERT INTO usuarios (usuario,contraseña,tipo,foto) VALUES('" + tbxUsuario.Text + "', '" + tbxContraseña.Text + "' , '" + CbxTipo.Text + "', '" + tbxPath.Text + "');";
                                MySqlCommand query = new MySqlCommand(consulta_query, conexionMysql);
                                query.ExecuteNonQuery();
                                MessageBox.Show("Registro Exitoso", "REGISTRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conexionMysql.Close();
                                this.Close();
                                clearEmployeRegistry();
                            }
                            catch (MySqlException)
                            {
                                MessageBox.Show("No se establecio conexión a la base de datos", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    if (!tbxPath.Text.Equals(""))
                    {
                        try
                        {
                            MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                            conexionMysql.Open();
                            string consulta_query = "INSERT INTO usuarios (usuario,contraseña,tipo,foto) VALUES('" + tbxUsuario.Text + "', '" + tbxContraseña.Text + "' , '" + CbxTipo.Text + "', '" + tbxPath.Text + "');";
                            MySqlCommand query = new MySqlCommand(consulta_query, conexionMysql);
                            query.ExecuteNonQuery();
                            MessageBox.Show("Registro Exitoso", "REGISTRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conexionMysql.Close();
                            this.Close();
                            clearEmployeRegistry();
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("No se establecio conexión a la base de datos", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("la contraseña no coincide","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tbxRContraseña.Clear();
                }
            }
        }

        private void btnRefreshEmploye_Click(object sender, EventArgs e)
        {
            if (pbxEmploye.Image != null)
            {
                pbxEmploye.Image.Dispose();
                pbxEmploye.Image = null;
            }
        }

        private void tbxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (tbxContraseña.Text.Equals(tbxRContraseña.Text))
            {
                if (!CbxTipo.Text.Equals("") || !tbxUsuario.Text.Equals("") || tbxContraseña.Text.Equals("") || tbxRContraseña.Text.Equals(""))
                {
                    try
                    {
                        MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                        conexionMysql.Open();
                        string consulta_query = "UPDATE usuarios SET usuario='" + tbxUsuario.Text + "', contraseña='" + tbxContraseña.Text + "', tipo='" + CbxTipo.Text + "', foto='" + tbxPath.Text + "' WHERE usuarios.id='" + tbxId.Text + "';";
                        MySqlCommand query = new MySqlCommand(consulta_query, conexionMysql);
                        query.ExecuteNonQuery();
                        MessageBox.Show("Registro Exitoso", "REGISTRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexionMysql.Close();
                        this.Close();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se establecio conexión a la base de datos", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Completa el formulario", "REGISTRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Contraseña con coincide", "REGISTRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlOperaciones_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
