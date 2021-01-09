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
    public partial class FormCrudAlmacen : Form
    {
        

        String connectionString = "Server=127.0.0.1;Port=3306;Database=gfoventas;Uid=gfoAdmin;Pwd=G.F.O.*2020Vts;";

        public int xClick = 0, yClick = 0;

        public FormCrudAlmacen()
        {
            InitializeComponent();
            if (!(tbxIdPro.Text.Equals("") && tbxIdVendedor.Text.Equals("")))
            {
                vendedor();
                producto();
            }

            /*cbxProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCantPro.DropDownStyle = ComboBoxStyle.DropDownList;*/
        }

        private void cbxVendedores_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionMysql = new MySqlConnection(connectionString);
            conexionMysql.Open();
            string query = "SELECT nombres from trabajador";
            MySqlCommand cmd = new MySqlCommand(query, conexionMysql);

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            cbxVendedores.ValueMember = "nombres";
            cbxVendedores.DisplayMember = "nombres";
            cbxVendedores.DataSource = dt;
            conexionMysql.Close();
        }

        public void id()
        {
            MySqlConnection conexionMysql = new MySqlConnection(connectionString);
            MySqlCommand command = conexionMysql.CreateCommand();
            command.CommandText = "SELECT id from trabajador where nombres = '" + cbxVendedores.Text + "';";
            conexionMysql.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbxIdVendedor.Text = Convert.ToString(reader["id"]);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un Vendedor", "VENDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexionMysql.Close();
        }

        public void idPro()
        {
            MySqlConnection conexionMysql = new MySqlConnection(connectionString);
            MySqlCommand command = conexionMysql.CreateCommand();
            command.CommandText = "SELECT id from productos where nombre = '" + cbxProductos.Text + "';";
            conexionMysql.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbxIdPro.Text = Convert.ToString(reader["id"]);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un Vendedor", "VENDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexionMysql.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSstatus_Click(object sender, EventArgs e)
        {
            id();
            idPro();
        }

        private void cbxProductos_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionMysql = new MySqlConnection(connectionString);
            conexionMysql.Open();
            string query = "SELECT nombre from productos";
            MySqlCommand cmd = new MySqlCommand(query, conexionMysql);

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            cbxProductos.ValueMember = "nombre";
            cbxProductos.DisplayMember = "nombre";
            cbxProductos.DataSource = dt;
            conexionMysql.Close();
        }

        private void pnlOperaciones_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        public void carga()
        {
            try
            {
                MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                conexionMysql.Open();
                string consulta_query = "INSERT INTO almacen (idProductos,idVendedor,cantidadProd,status) VALUES('" + tbxIdPro.Text + "', '" + tbxIdVendedor.Text + "' , '" + cbxCantPro.Text + "', '" + cbxSstatus.Text + "');";
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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            carga();
            FormCrudAlmacen Almacen = new FormCrudAlmacen();
            Almacen.Show();
            FormAlmacen almacent = new FormAlmacen();
            almacent.loadAlmacen();
        }

        private void cbxCantPro_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                cbxCantPro.Items.Add(i);
            }
        }

        public void producto()
        {
            MySqlConnection conexionMysql = new MySqlConnection(connectionString);
            MySqlCommand command = conexionMysql.CreateCommand();
            command.CommandText = "SELECT nombre from producto where id = '" + tbxIdPro.Text + "';";
            conexionMysql.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cbxProductos.Text = Convert.ToString(reader["nombe"]);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un Vendedor", "VENDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexionMysql.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        public void vendedor()
        {
            MySqlConnection conexionMysql = new MySqlConnection(connectionString);
            MySqlCommand command = conexionMysql.CreateCommand();
            command.CommandText = "SELECT nombres from trabajador where id = '" + tbxIdVendedor.Text + "';";
            conexionMysql.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cbxVendedores.Text = Convert.ToString(reader["nombres"]);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un Vendedor", "VENDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexionMysql.Close();
        }

        public void editar()
        {
            if ( !tbxID.Text.Equals("") ||!cbxProductos.Text.Equals("") || !tbxIdPro.Text.Equals("") || !cbxVendedores.Text.Equals("") || !tbxIdVendedor.Text.Equals("") || !cbxCantPro.Text.Equals("") || !cbxSstatus.Text.Equals(""))
            {
                try
                {
                    MySqlConnection conexionMysql = new MySqlConnection(connectionString);
                    conexionMysql.Open();
                    string consulta_query = "UPDATE almacen SET idProductos='" + tbxIdPro.Text + "', idVendedor='" + tbxIdVendedor.Text + "', cantidadProd='" + cbxCantPro.Text + "', status='" + cbxSstatus.Text + "' where id='" + tbxID.Text + "';";
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
    }
}
