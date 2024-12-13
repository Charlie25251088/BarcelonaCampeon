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
using Pubs.Datos;

namespace Pubs
{
    public partial class FrmEmployee : Form
    {
        private readonly conexion dbConexion = new conexion();

        public FrmEmployee()
        {
            InitializeComponent();
            CargarEmployee();
        }

        private void CargarEmployee()
        {
            using (SqlConnection conn = new conexion().obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Employee";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable employeeTable = new DataTable();
                    adapter.Fill(employeeTable);
                    dataGridView1.DataSource = employeeTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}");
                }
            }
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
