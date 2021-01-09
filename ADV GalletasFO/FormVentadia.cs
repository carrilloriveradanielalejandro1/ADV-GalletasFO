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
    public partial class FormVentadia : Form
    {
        String connectionString = "Server=127.0.0.1;Port=3306;Database=gfoventas;Uid=gfoAdmin;Pwd=G.F.O.*2020Vts;";

        public FormVentadia()
        {
            InitializeComponent();
            loadventas();
        }

        public void loadventas()
        {
            try
            {
                MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                conexionMysql.Open();
                string consulta_query = "SELECT * from ventadia";
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
    }
}
