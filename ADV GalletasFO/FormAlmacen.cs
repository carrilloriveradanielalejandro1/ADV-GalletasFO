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
    public partial class FormAlmacen : Form
    {
        String connectionString = "Server=127.0.0.1;Port=3306;Database=gfoventas;Uid=gfoAdmin;Pwd=G.F.O.*2020Vts;";

        public static string id;
        public static string idPro;
        public static string idVen;

        public FormAlmacen()
        {
            InitializeComponent();
            loadAlmacen();
        }

        public void loadAlmacen()
        {
            try
            {
                MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                conexionMysql.Open();
                string consulta_query = "select almacen.id AS ID, productos.id AS ID_PROD, productos.nombre AS PRODUCTO, trabajador.id AS ID_VEND,  trabajador.nombres AS VENDEDOR, cantidadProd  AS CANTIDAD, status AS ESTADO, nomDia AS DIA, numSem AS NUM_SEMANA, fecha AS FECHA, preXcant PRECIO_PRO_TOTAL from productos, trabajador, almacen where almacen.idProductos=productos.id && almacen.idVendedor=trabajador.id && almacen.enabled=1;";
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
            loadAlmacen();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCrudAlmacen crudAlmacen = new FormCrudAlmacen();
            crudAlmacen.btnEditar.Visible = false;
            crudAlmacen.Show();
        }

        private void dgwEmploye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgwEmploye.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine(id);
            idPro = dgwEmploye.CurrentRow.Cells[1].Value.ToString();
            idVen = dgwEmploye.CurrentRow.Cells[3].Value.ToString();
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

        public void editar()
        {
            try
            {
                MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                MySqlCommand command = conexionMysql.CreateCommand();
                command.CommandText = "select almacen.id AS ID, productos.id AS ID_PROD, productos.nombre AS PRODUCTO, trabajador.id AS ID_VEND,  trabajador.nombres AS VENDEDOR, cantidadProd  AS CANTIDAD, status AS ESTADO from productos, trabajador, almacen where almacen.idProductos=productos.id && almacen.idVendedor=trabajador.id && almacen.enabled=1 && almacen.id='" + Convert.ToString(id) + "';";
                conexionMysql.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        FormCrudAlmacen formCargaEditar = new FormCrudAlmacen();
                        formCargaEditar.tbxID.Text= Convert.ToString(reader["ID"]);
                        formCargaEditar.tbxIdPro.Text = Convert.ToString(reader["ID_PROD"]);
                        formCargaEditar.cbxProductos.Text = Convert.ToString(reader["PRODUCTO"]);
                        formCargaEditar.tbxIdVendedor.Text = Convert.ToString(reader["ID_VEND"]);
                        formCargaEditar.cbxVendedores.Text = Convert.ToString(reader["VENDEDOR"]);
                        formCargaEditar.cbxCantPro.Text = Convert.ToString(reader["CANTIDAD"]);
                        formCargaEditar.cbxSstatus.Text = Convert.ToString(reader["ESTADO"]);
                        formCargaEditar.btnCargar.Visible = false;
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

        public void Eliminar()
        {
            DialogResult result = MessageBox.Show("¿Deseas Eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == result)
            {
                try
                {
                    MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                    conexionMysql.Open();
                    string consulta_query = "UPDATE almacen SET enabled=0 where idProductos=('" + Convert.ToString(idPro) + "') && idVendedor=('" + Convert.ToString(idVen) + "');";
                    MySqlCommand query = new MySqlCommand(consulta_query, conexionMysql);
                    MySqlDataAdapter data = new MySqlDataAdapter(query);
                    DataSet dataset = new DataSet();
                    data.Fill(dataset);
                    conexionMysql.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("La conexion no ha tenido exito", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadAlmacen();
            }
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
    }
}
