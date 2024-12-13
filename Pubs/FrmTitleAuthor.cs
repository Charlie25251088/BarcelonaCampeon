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
    public partial class FrmTitleAuthor : Form
    {
        private readonly conexion dbConexion = new conexion();
        public FrmTitleAuthor()
        {
            InitializeComponent();
            CargarTitleAuthor();
        }

        private void CargarTitleAuthor()
        {
            using (SqlConnection conn = new conexion().obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM TitleAuthor";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable titleAuthorTable = new DataTable();
                    adapter.Fill(titleAuthorTable);
                    dataGridView1.DataSource = titleAuthorTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}");
                }
            }
        }


        private void FrmTitleAuthor_Load(object sender, EventArgs e)
        {

        }
    }
}
