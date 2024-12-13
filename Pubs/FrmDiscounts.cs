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
    public partial class FrmDiscounts : Form
    {
        private readonly conexion dbConexion = new conexion();
        public FrmDiscounts()
        {
            InitializeComponent();
            CargarDescuentos();
        }

        private void CargarDescuentos()
        {
            using (SqlConnection conn = dbConexion.obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Authors";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable authorsTable = new DataTable();
                    adapter.Fill(authorsTable);
                    dataGridView1.DataSource = authorsTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDiscounts_Load(object sender, EventArgs e)
        {

        }
    }
}
