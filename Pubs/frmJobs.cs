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
    public partial class frmJobs : Form
    {
        private readonly conexion dbConexion = new conexion();
        public frmJobs()
        {
            InitializeComponent();
            CargarJobs();
        }

        private void CargarJobs()
        {
            using (SqlConnection conn = new conexion().obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Jobs";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable jobsTable = new DataTable();
                    adapter.Fill(jobsTable);
                    dataGridView1.DataSource = jobsTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}");
                }
            }
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {

        }
    }
}
