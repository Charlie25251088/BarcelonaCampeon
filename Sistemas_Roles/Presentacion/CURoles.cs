using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemas_Roles.Datos;
using Sistemas_Roles.Logica;

namespace Sistemas_Roles.Presentacion
{
    public partial class CURoles : UserControl
    {
        public CURoles()
        {
            InitializeComponent();
            CargarRoles();

        }

        public void CargarRoles()
        {
            try
            {
                // Crear la conexión
                conexion con = new conexion();
                using (SqlConnection connection = con.obtenerConexion())
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos
                    string query = "SELECT * FROM Roles";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    adapter.Fill(dt);

                    // Asignar los datos al DataGridView
                    dgvRoles.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnInsertarR_Click(object sender, EventArgs e)
        {
            FrmInsertarRoles frmInsertarRoles = new FrmInsertarRoles();
            frmInsertarRoles.ShowDialog(); // Abrir el formulario como modal
            CargarRoles(); // Método que refresca el DataGridView
        }

        private void btnActualizarR_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells["Rol_Id"].Value);
                string detalle = dgvRoles.SelectedRows[0].Cells["Detalle"].Value.ToString();

                FrmInsertarRoles formEditar = new FrmInsertarRoles(id, detalle);
                formEditar.ShowDialog();

                CargarRoles(); // Refrescar DataGridView
            }
            else
            {
                MessageBox.Show("Seleccione un rol para editar.");
            }
        }

        private void btnEliminarR_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells["Rol_Id"].Value);

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este rol?",
                                                            "Confirmar eliminación",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    cls_roles rol = new cls_roles();
                    bool resultado = rol.EliminarRol(id);

                    if (resultado)
                    {
                        MessageBox.Show("Rol eliminado correctamente.");
                        CargarRoles(); // Refrescar DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el rol.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un rol para eliminar.");
            }
        }
    }
}
