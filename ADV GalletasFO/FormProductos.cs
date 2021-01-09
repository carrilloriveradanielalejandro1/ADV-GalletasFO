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
    public partial class FormProductos : Form
    {
        String connectionString = "Server=127.0.0.1;Port=3306;Database=gfoventas;Uid=gfoAdmin;Pwd=G.F.O.*2020Vts;";

        public FormProductos()
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
                string consulta_query = "SELECT id AS ID, nombre AS PRODUCTO, kilo AS PESO, preXkilo AS PRE_KILO, ttlPrecio AS PRECIO from PRODUCTOS where enabled=1 ";
                MySqlCommand query = new MySqlCommand(consulta_query, conexionMysql);
                MySqlDataAdapter data = new MySqlDataAdapter(query);
                DataSet dataset = new DataSet();
                data.Fill(dataset);
                dgwProductos.DataSource = dataset.Tables[0];
                conexionMysql.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("La conexion no ha tenido exito", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshEmploye_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCrudProductos productos = new FormCrudProductos();
            productos.btnEditar.Visible = false;
            productos.Show();
        }
    }
}
