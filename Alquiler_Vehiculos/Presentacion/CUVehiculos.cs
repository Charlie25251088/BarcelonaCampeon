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
    public partial class CUVehiculos : UserControl
    {
        private cls_vehiculos clsVehiculos = new cls_vehiculos();
        public CUVehiculos()
        {
            InitializeComponent();
        }

        public void CargarVehiculos()
        {
            // Llama al método ObtenerClientes de cls_clientes
            var listaVehiculos = clsVehiculos.ObtenerVehiculos();

            // Asigna los datos al DataGridView
            dataGridViewVehiculos.DataSource = listaVehiculos;
        }



        private void btnInsertarV_Click(object sender, EventArgs e)
        {
            FrmInsertarVehiculo frmInsertarVehiculo = new FrmInsertarVehiculo();
            frmInsertarVehiculo.ShowDialog();
        }

        private void btnEditarV_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewVehiculos.SelectedRows[0];
                FrmInsertarVehiculo frmInsertarVehiculo = new FrmInsertarVehiculo
                {
                    Id_Vehiculo = Convert.ToInt32(filaSeleccionada.Cells[0].Value),
                    Marca = filaSeleccionada.Cells[1].Value.ToString(),
                    Modelo = filaSeleccionada.Cells[2].Value.ToString(),
                    Anio = Convert.ToInt32(filaSeleccionada.Cells[3].Value),
                    Precio = Convert.ToDecimal(filaSeleccionada.Cells[4].Value),
                    Estado = filaSeleccionada.Cells[5].Value.ToString()
                };
                frmInsertarVehiculo.ShowDialog();
                CargarVehiculos();
            }
        }

        private void btnEliminarV_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewVehiculos.SelectedRows[0];
                int idVehiculo = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este vehículo?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool exito = clsVehiculos.EliminarVehiculo(idVehiculo);
                    if (exito)
                    {
                        MessageBox.Show("Vehículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarVehiculos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
    
