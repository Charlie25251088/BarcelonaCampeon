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
    public partial class FrmInsertarUsuarios : Form
    {
        private int usuarioId = 0;  // 0 indica que se está insertando un usuario nuevo
        public FrmInsertarUsuarios()
        {
            InitializeComponent();
            CargarRoles(); // Cargar roles en el ComboBox al abrir el formulario
        }

        private void CargarRoles()
        {
            try
            {
                conexion con = new conexion();
                using (SqlConnection connection = con.obtenerConexion())
                {
                    connection.Open();
                    string query = "SELECT Rol_Id, Detalle FROM Roles";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbRoles.DataSource = dt;
                    cmbRoles.DisplayMember = "Detalle";
                    cmbRoles.ValueMember = "Rol_Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {            

            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                char disponibilidad = cmbDisponibilidad.SelectedItem.ToString()[0];
                int roles_id = Convert.ToInt32(cmbRoles.SelectedValue);

                cls_usuarios usuario = new cls_usuarios();
                bool resultado;

                if (usuarioId == 0)  // Si es 0, se inserta un nuevo usuario
                {
                    resultado = usuario.InsertarUsuario(username, password, disponibilidad, roles_id);
                }
                else  // Si tiene un ID válido, se actualiza
                {
                    resultado = usuario.ActualizarUsuario(usuarioId, username, password, disponibilidad, roles_id);
                }

                if (resultado)
                {
                    MessageBox.Show("Operación realizada con éxito.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CargarDatos(int id, string username, string password, char disponibilidad, int roles_id)
        {
            usuarioId = id;
            txtUsername.Text = username;
            txtPassword.Text = password;
            cmbDisponibilidad.SelectedItem = disponibilidad.ToString();
            cmbRoles.SelectedValue = roles_id;
        }

    }
}
