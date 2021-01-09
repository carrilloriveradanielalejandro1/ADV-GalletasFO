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

//ESTA ES LA VERSION BASE

namespace ADV_GalletasFO
{
    public partial class formIngreso : Form
    {

        String connectionString = "Server=127.0.0.1;Port=3306;Database=gfoventas;Uid=gfoAdmin;Pwd=G.F.O.*2020Vts;";

        public formIngreso()
        {
            InitializeComponent();
        }

        frmPrincipal formPrincipal = new frmPrincipal();

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            IngresoUsuario();
        }

        private void tbxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IngresoUsuario();
            }
        }

        public void IngresoUsuario()
        {
            if (tbxUsuario.Text.Equals("") || tbxContraseña.Text.Equals(""))
            {
                MessageBox.Show("Completa los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                    MySqlCommand command = conexionMysql.CreateCommand();
                    command.CommandText = "select usuario, TRIM(contraseña), tipo, foto from usuarios where usuario='" + tbxUsuario.Text + "' and TRIM(contraseña='" + tbxContraseña.Text + "') and enabled=1;";
                    conexionMysql.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (Convert.ToString(reader["usuario"]).Equals(tbxUsuario.Text) )
                            {
                                try
                                {
                                    MySqlConnection conexionMysql2 = new MySqlConnection(connectionString);
                                    conexionMysql2.Open();
                                    string consulta_query = "UPDATE usuarios SET activo=true WHERE usuario='" + tbxUsuario.Text + "' and contraseña='" + tbxContraseña.Text + "' and enabled=true;";
                                    MySqlCommand query = new MySqlCommand(consulta_query, conexionMysql2);
                                    query.ExecuteNonQuery();
                                    conexionMysql2.Close();
                                    this.Close();

                                    formPrincipal.tbxUsuario.Text = Convert.ToString(reader["usuario"]);
                                    formPrincipal.tbxTipo.Text = Convert.ToString(reader["tipo"]);
                                    
                                    //formPrincipal.pbxUsuario.ImageLocation = Convert.ToString(reader["image"]);
                                    
                                    

                                    if (Convert.ToString(reader["tipo"]) == "ADMINISTRADOR")
                                    {
                                        formPrincipal.Show();
                                    }
                                    else if (Convert.ToString(reader["tipo"]) == "SECRETARIA")
                                    { 
                                        formPrincipal.btnAlmacen.Visible = false;
                                        formPrincipal.btnCarga.Visible = false;
                                        formPrincipal.Show();
                                    }
                                    else if (Convert.ToString(reader["tipo"]) == "ALMACEN")
                                    {

                                        formPrincipal.BtnEmpleados.Visible = false;
                                        formPrincipal.btnCorte.Visible = false;
                                        formPrincipal.btnReportes.Visible = false;
                                        formPrincipal.btnNomina.Visible = false;
                                        formPrincipal.Show();
                                    }
                                }
                                catch (MySqlException)
                                {
                                    MessageBox.Show("No se establecio conexión a la base de datos", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                ClearUsers();
                                MessageBox.Show("Clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        ClearUsers();
                        MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conexionMysql.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se establecio conexión a la base de datos", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        public void ClearUsers()
        {
            tbxUsuario.Clear();
            tbxContraseña.Clear();

        }
        public void ingresoSistema()
        {
            if (!(tbxUsuario.Text.Equals("") && tbxContraseña.Text.Equals("")))
            {
                if (tbxUsuario.Text.Equals("ADMINISTRADOR") && tbxContraseña.Text.Equals("ADMIN.*2020"))
                {
                    limpiarCampos();
                    this.Close();
                    //formPrincipal.textBox2.Text = "CARLOS MACIAS";
                    //formPrincipal.tbxTipo.Text = "ADMINISTRADOR";
                    formPrincipal.Show();
                }
                else
                {
                    String mensaje = "Usuario o Contraseña incorrectos";
                    String titulo = "Error";
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBoxIcon error = MessageBoxIcon.Error;
                    MessageBox.Show(mensaje, titulo, ok, error);
                    limpiarCampos();
                }
            }
            else
            {
                String mensaje = "Usuario o Contraseña incorrectos";
                String titulo = "Error";
                MessageBoxButtons ok = MessageBoxButtons.OK;
                MessageBoxIcon error = MessageBoxIcon.Error;
                MessageBox.Show(mensaje, titulo, ok, error);
                limpiarCampos();
            }
        }

        public void limpiarCampos()
        {
            tbxUsuario.Clear();
            tbxContraseña.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Deseas abandonar el programa?";
            String advertencia = "CERRAR";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult resultado = MessageBox.Show(mensaje, advertencia, buttons, icon);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text.Equals("") && tbxContraseña.Text.Equals(""))
            {
                String mensaje = "¿Deseas abandonar el programa?";
                String advertencia = "CERRAR";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                DialogResult resultado = MessageBox.Show(mensaje, advertencia, buttons, icon);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                    Application.Exit();
            }
            else
            {
                limpiarCampos();
            }
        }
    }
}
