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
    public partial class FrmSales : Form
    {
        private readonly conexion dbConexion = new conexion();
        public FrmSales()
        {
            InitializeComponent();
            CargarSales();
        }

        private void CargarSales()
        {
            using (SqlConnection conn = new conexion().obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Sales";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable salesTable = new DataTable();
                    adapter.Fill(salesTable);
                    dataGridView1.DataSource = salesTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSales_Load(object sender, EventArgs e)
        {

        }
    }
}
