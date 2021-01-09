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
    public partial class FormCrudProductos : Form
    {
        String connectionString = "Server=127.0.0.1;Port=3306;Database=gfoventas;Uid=gfoAdmin;Pwd=G.F.O.*2020Vts;";

        public int xClick = 0, yClick = 0;

        public FormCrudProductos()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        public void carga()
        {
            try
            {
                MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                conexionMysql.Open();
                string consulta_query = "INSERT INTO productos (nombre,kilo,preXkilo) VALUES('" + Text + "', '" + tbxProducto.Text + "' , '" + tbxKilos.Text + "', '" + tbxPreKilos.Text + "');";
                MySqlCommand query = new MySqlCommand(consulta_query, conexionMysql);
                query.ExecuteNonQuery();
                conexionMysql.Close();
                this.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se establecio conexión a la base de datos", "base datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
