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
    public partial class FormEmpleados : Form
    {
        // gfoAdmin G.F.O.*2020Vts
        String connectionString = "Server=127.0.0.1;Port=3306;Database=gfoventas;Uid=gfoAdmin;Pwd=G.F.O.*2020Vts;";

        public static string id;
        public static string usuario;

        public FormEmpleados()
        {
            InitializeComponent();
            employeLoad();
            
        }

        public void employeLoad()
        {
            try
            {
                MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                conexionMysql.Open();
                string consulta_query = "select id AS ID, usuario AS USUARIO, tipo AS TIPO from usuarios where enabled=1";
                MySqlCommand query = new MySqlCommand(consulta_query, conexionMysql);
                MySqlDataAdapter data = new MySqlDataAdapter(query);
                DataSet dataset = new DataSet();
                data.Fill(dataset);
                dgwEmploye.DataSource = dataset.Tables[0];
                conexionMysql.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("La conexion no ha tenido exito", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnRefreshEmploye_Click(object sender, EventArgs e)
        {
            employeLoad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCrudEmpleados addEmploye = new FormCrudEmpleados();
            addEmploye.btnModificar.Visible = false;
            addEmploye.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                editar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un Registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgwEmploye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgwEmploye.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgwEmploye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                editar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un Registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editar()
        {
            try
            {
                MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                MySqlCommand command = conexionMysql.CreateCommand();
                command.CommandText = "select id, usuario, contraseña, tipo, foto from usuarios where id='" + Convert.ToString(id) + "' and enabled=1;";
                conexionMysql.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        FormCrudEmpleados formCargaEditar = new FormCrudEmpleados();
                        formCargaEditar.tbxUsuario.Text = Convert.ToString(reader["usuario"]);
                        formCargaEditar.tbxContraseña.Text = Convert.ToString(reader["contraseña"]);
                        formCargaEditar.tbxRContraseña.Text = Convert.ToString(reader["contraseña"]);
                        formCargaEditar.CbxTipo.Text = Convert.ToString(reader["tipo"]);
                        formCargaEditar.pbxEmploye.ImageLocation = Convert.ToString(reader["foto"]);
                        formCargaEditar.tbxId.Text = Convert.ToString(reader["id"]);
                        formCargaEditar.btnAgregar.Visible = false;
                        formCargaEditar.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona Registro", "EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("La conexion no ha tenido exito", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar()
        {
            DialogResult result = MessageBox.Show("¿Deseas Eliminar?","Eliminar",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == result)
            {
                try
                {
                    MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                    conexionMysql.Open();
                    string consulta_query = "UPDATE usuarios SET enabled=0 where id=('" + Convert.ToString(id) + "');";
                    MySqlCommand query = new MySqlCommand(consulta_query, conexionMysql);
                    MySqlDataAdapter data = new MySqlDataAdapter(query);
                    DataSet dataset = new DataSet();
                    data.Fill(dataset);
                    conexionMysql.Close();
                    employeLoad();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("La conexion no ha tenido exito", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un Registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
