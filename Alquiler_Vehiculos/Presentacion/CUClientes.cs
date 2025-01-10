using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alquiler_Vehiculos.Logica;
using Alquiler_Vehiculos.Datos;

namespace Alquiler_Vehiculos.Presentacion
{
    public partial class CUClientes : UserControl
    {
        private cls_clientes clsClientes = new cls_clientes();
        public CUClientes()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            // Llama al método ObtenerClientes de cls_clientes
            var listaClientes = clsClientes.ObtenerClientes();

            // Asigna los datos al DataGridView
            dataGridViewClientes.DataSource = listaClientes;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmInsertar frmInsertar = new FrmInsertar();
            frmInsertar.ShowDialog(); // Abrir el formulario como modal
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridViewClientes.SelectedRows[0];

                // Crear una instancia del formulario FrmInsertar
                FrmInsertar frmInsertar = new FrmInsertar();

                // Asignar los valores de la fila seleccionada a las propiedades del formulario
                frmInsertar.Id_Cliente = Convert.ToInt32(filaSeleccionada.Cells["Id_Cliente"].Value); // Usando el nombre de la columna
                frmInsertar.Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString(); // Usando el nombre de la columna
                frmInsertar.Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString(); // Usando el nombre de la columna
                frmInsertar.Cedula = filaSeleccionada.Cells["Cedula"].Value.ToString(); // Usando el nombre de la columna
                frmInsertar.Telefono = filaSeleccionada.Cells["Telefono"].Value.ToString(); // Usando el nombre de la columna
                frmInsertar.Email = filaSeleccionada.Cells["Email"].Value.ToString(); // Usando el nombre de la columna
                frmInsertar.Direccion = filaSeleccionada.Cells["Direccion"].Value.ToString(); // Usando el nombre de la columna

                // Mostrar el formulario de edición
                frmInsertar.ShowDialog();

                // Actualizar el DataGridView después de editar
                CargarDatos(); // Reemplaza esto con tu método para recargar los datos
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                // Mostrar un cuadro de confirmación
                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario confirma que sí
                if (resultado == DialogResult.Yes)
                {
                    // Obtener el ID del cliente de la fila seleccionada (suponiendo que el ID esté en la primera columna)
                    int idCliente = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells[0].Value);

                    // Llamar al método para eliminar el cliente de la base de datos
                    cls_clientes clsClientes = new cls_clientes();
                    bool exito = clsClientes.EliminarCliente(idCliente);

                    // Si se eliminó correctamente
                    if (exito)
                    {
                        MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar los datos en el DataGridView
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
    }
    }
}
