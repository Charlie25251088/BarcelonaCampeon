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
    public partial class FrmPubInfo : Form
    {
        private readonly conexion dbConexion = new conexion();
        public FrmPubInfo()
        {
            InitializeComponent();
            CargarPubInfo();
        }

        private void CargarPubInfo()
        {
            using (SqlConnection conn = new conexion().obtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Pub_Info";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable pubInfoTable = new DataTable();
                    adapter.Fill(pubInfoTable);
                    dataGridView1.DataSource = pubInfoTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}");
                }
            }
        }


        private void FrmPubInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
