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
using Sistemas_Roles.Presentacion;

namespace Sistemas_Roles.Presentacion
{
    public partial class CUUsuarios : UserControl
    {
        public CUUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            try
            {
                // Crear la conexión
                conexion con = new conexion();
                using (SqlConnection connection = con.obtenerConexion())
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos
                    string query = "SELECT * FROM Usuarios";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    adapter.Fill(dt);

                    // Asignar los datos al DataGridView
                    dgvUsuarios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnInsertarU_Click(object sender, EventArgs e)
        {
            FrmInsertarUsuarios frmInsertarUsuarios = new FrmInsertarUsuarios();
            frmInsertarUsuarios.ShowDialog(); // Abrir el formulario como modal
            CargarUsuarios(); // Método que refresca el DataGridView
        }

        private void btnActualizarU_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id_User"].Value);
                string username = dgvUsuarios.SelectedRows[0].Cells["Username"].Value.ToString();
                string password = dgvUsuarios.SelectedRows[0].Cells["Password"].Value.ToString();
                char disponibilidad = Convert.ToChar(dgvUsuarios.SelectedRows[0].Cells["Disponibilidad"].Value);
                int roles_id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Roles_id"].Value);

                FrmInsertarUsuarios formEditar = new FrmInsertarUsuarios();
                formEditar.CargarDatos(id, username, password, disponibilidad, roles_id);
                formEditar.ShowDialog();

                CargarUsuarios(); // Refrescar DataGridView
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para editar.");
            }
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id_User"].Value);

                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    cls_usuarios usuario = new cls_usuarios();
                    if (usuario.EliminarUsuario(id))
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        CargarUsuarios(); // Refrescar DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }
        }
    }
}