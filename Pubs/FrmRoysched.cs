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
    public partial class FrmRoysched : Form
    {
        private readonly conexion dbConexion = new conexion();
        public FrmRoysched()
        {
            InitializeComponent();
            CargarRoysched();
        }

        private void CargarRoysched()
        {
            using (SqlConnection conn = new conexion().obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Roysched";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable royschedTable = new DataTable();
                    adapter.Fill(royschedTable);
                    dataGridView1.DataSource = royschedTable;
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

        private void FrmRoysched_Load(object sender, EventArgs e)
        {

        }
    }
}
