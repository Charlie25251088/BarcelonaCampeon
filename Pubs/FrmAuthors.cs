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
    public partial class FrmAuthors : Form
    {
        private readonly conexion dbConexion = new conexion();
        public FrmAuthors()
        {
            InitializeComponent();
            CargarAutores();
        }

        private void CargarAutores()
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
        private void FrmAuthors_Load(object sender, EventArgs e)
        {

        }
    }
}
