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
    public partial class FrmTitles : Form
    {
        private readonly conexion dbConexion = new conexion();
        public FrmTitles()
        {
            InitializeComponent();
            CargarTitles();
        }

        private void CargarTitles()
        {
            using (SqlConnection conn = new conexion().obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Titles";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable titlesTable = new DataTable();
                    adapter.Fill(titlesTable);
                    dataGridView1.DataSource = titlesTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}");
                }
            }
        }

        private void FrmTitles_Load(object sender, EventArgs e)
        {

        }
    }
}
