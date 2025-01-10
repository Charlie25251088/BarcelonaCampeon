using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alquiler_Vehiculos.Logica;

namespace Alquiler_Vehiculos.Presentacion
{
    public partial class FrmInsertarVehiculo : Form
    {
        public int Id_Vehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; }

        public FrmInsertarVehiculo()
        {
            InitializeComponent();
        }
        private cls_vehiculos clsVehiculos = new cls_vehiculos();
        private void FrmInsertarVehiculo_Load(object sender, EventArgs e)
        {
            // Si se va a editar, cargar los datos en los controles
            if (Id_Vehiculo != 0)
            {
                txtMarca.Text = Marca;
                txtModelo.Text = Modelo;
                txtAnio.Text = Anio.ToString();
                txtPrecio.Text = Precio.ToString();
                txtEstado.Text = Estado;
            }
        }

        private void btnGuardarV_Click(object sender, EventArgs e)
        {
            // Validación de los campos
            if (string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtEstado.Text) || !int.TryParse(txtAnio.Text, out int anio) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor, rellene todos los campos correctamente.");
                return;
            }

            // Llamar al método InsertarVehiculo
            bool exito = clsVehiculos.InsertarVehiculo(txtMarca.Text, txtModelo.Text, anio, precio, txtEstado.Text);

            if (exito)
            {
                MessageBox.Show("Vehículo insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show("Error al insertar el vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
