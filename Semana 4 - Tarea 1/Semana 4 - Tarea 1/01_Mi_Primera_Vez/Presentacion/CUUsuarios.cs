using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Mi_Primera_Vez.Logica;
using _01_Mi_Primera_Vez.Presentacion.Usuarios;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class CUUsuarios : UserControl
    {
        private readonly cls_usuarios _clsUsuarios = new cls_usuarios(); // Esto debe estar aquí

        public CUUsuarios()
        {
            InitializeComponent();
        }

        private void btnUnuevo_Click(object sender, EventArgs e)
        {
            // Abre el formulario para agregar un nuevo usuario
            var frm = new FrmUsuarios();
            frm.ShowDialog();

            // Actualiza la lista de usuarios después de cerrar el formulario
            CargarUsuarios();
        }

        private void btnUbuscar_Click(object sender, EventArgs e)
        {
            // Busca usuarios filtrados por el texto en txtUbuscar
            var clsUsuarios = new cls_usuarios();
            dataGridView2.DataSource = clsUsuarios.Leer(txtUbuscar.Text);
        }

        private void CargarUsuarios()
        {
            // Carga todos los usuarios en el DataGridView
            var clsUsuarios = new cls_usuarios();
            dataGridView2.DataSource = clsUsuarios.Leer();
        }

        private void CUUsuarios_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar los datos al iniciar
            CargarUsuarios();
        }

        private void btnUnuevo_Click_1(object sender, EventArgs e)
        {
            var frm = new FrmUsuarios(); // Abre el formulario para insertar un nuevo usuario
            frm.ShowDialog();
            CargarUsuarios(); // Actualiza el DataGridView después de cerrar el formulari
        }

        private void btnUeditar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.");
                return;
            }

            // Obtener el IdUsuario y NombreUsuario de la fila seleccionada
            int idUsuario = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["IdUsuario"].Value);
            string nombreUsuario = dataGridView2.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();

            // Crear una nueva instancia de FrmUsuarios
            FrmUsuarios frmEditar = new FrmUsuarios();

            // Establecer los valores del usuario a través de una propiedad o método
            frmEditar.CargarDatos(idUsuario, nombreUsuario);

            // Mostrar el formulario de edición
            frmEditar.ShowDialog();

            // Recargar los usuarios después de cerrar el formulario
            CargarUsuarios();
        }

        private void btnUeliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value); // Obtener el IdUsuario

                // Preguntar si realmente se quiere eliminar el usuario
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Eliminar el usuario
                    string resultado = _clsUsuarios.Eliminar(idUsuario);

                    if (resultado == "ok")
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        CargarUsuarios();  // Recargar el DataGridView después de eliminar
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }        
    }
}

