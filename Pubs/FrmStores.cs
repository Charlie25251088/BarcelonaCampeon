using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Pubs.Datos;

namespace Pubs
{
    public partial class FrmStores : Form
    {
        private readonly conexion dbConexion = new conexion();
        public FrmStores()
        {
            InitializeComponent();
            CargarStores();
        }

        private void CargarStores()
        {
            using (SqlConnection conn = new conexion().obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Stores";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable storesTable = new DataTable();
                    adapter.Fill(storesTable);
                    dataGridView1.DataSource = storesTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}");
                }
            }
        }

        private void FrmStores_Load(object sender, EventArgs e)
        {

        }
    }
}
