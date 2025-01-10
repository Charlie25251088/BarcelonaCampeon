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

namespace Alquiler_Vehiculos.Presentacion
{
    public partial class FrmInsertar : Form
    {
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public FrmInsertar()
        {
            InitializeComponent();
        }

        private void FrmInsertar_Load(object sender, EventArgs e)
        {
            // Solo cargar datos si se está editando (IdCliente > 0)
            if (Id_Cliente > 0)
            {
                // Asignar los valores a los TextBox
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                txtCedula.Text = Cedula;
                txtTelefono.Text = Telefono;
                txtEmail.Text = Email;
                txtDireccion.Text = Direccion;

                // Agregar depuración para verificar los valores
                Console.WriteLine($"Id_Cliente: {Id_Cliente}, Nombre: {Nombre}, Apellido: {Apellido}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cls_clientes clsClientes = new cls_clientes();

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string email = txtEmail.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool exito;

            if (Id_Cliente > 0) // Actualizar cliente
            {
                exito = clsClientes.ActualizarCliente(Id_Cliente, nombre, apellido, cedula, telefono, email, direccion);
            }
            else // Insertar nuevo cliente
            {
                exito = clsClientes.InsertarCliente(nombre, apellido, cedula, telefono, email, direccion);
            }

            if (exito)
            {
                MessageBox.Show("Operación realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar la operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
