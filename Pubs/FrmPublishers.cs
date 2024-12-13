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
    public partial class FrmPublishers : Form
    {
        private readonly conexion dbConexion = new conexion();
        public FrmPublishers()
        {
            InitializeComponent();
            CargarPublishers();
        }

        private void CargarPublishers()
        {
            using (SqlConnection conn = new conexion().obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Publishers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable publishersTable = new DataTable();
                    adapter.Fill(publishersTable);
                    dataGridView1.DataSource = publishersTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}");
                }
            }
        }


        private void FrmPublishers_Load(object sender, EventArgs e)
        {

        }
    }
}
