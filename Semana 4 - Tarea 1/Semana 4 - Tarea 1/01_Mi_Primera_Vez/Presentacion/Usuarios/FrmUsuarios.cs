using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Mi_Primera_Vez.Datos;  // Asegúrate de tener el espacio de nombres adecuado
using _01_Mi_Primera_Vez.Logica;

namespace _01_Mi_Primera_Vez.Presentacion.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        // Instancia de la clase de lógica para usuarios
        private readonly cls_usuarios _clsUsuarios = new cls_usuarios();
        private int _idUsuario; // Para almacenar el ID del usuario
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        // Método para cargar los datos del usuario a editar
        public void CargarDatos(int idUsuario, string nombreUsuario)
        {
            _idUsuario = idUsuario;
            txtNusuario.Text = nombreUsuario; // Establecer el valor del TextBox
            btnUguardar.Text = "Actualizar"; // Cambiar el texto del botón a "Actualizar"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(txtNusuario.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario.");
                return;
            }

            // Verificar si estamos actualizando un usuario o insertando uno nuevo
            if (_idUsuario > 0) // Si _idUsuario tiene un valor, estamos actualizando
            {
                // Ejecutar el método de actualización
                string resultado = _clsUsuarios.Actualizar(_idUsuario, txtNusuario.Text);

                if (resultado == "ok")
                {
                    MessageBox.Show("Usuario actualizado correctamente.");
                    this.Close();  // Cierra el formulario después de guardar
                }
                else
                {
                    MessageBox.Show("Error al actualizar el usuario.");
                }
            }
            else
            {
                // Si no estamos actualizando, estamos insertando un nuevo usuario
                var nuevoUsuario = new dto_usuarios
                {
                    NombreUsuario = txtNusuario.Text
                };

                string resultado = _clsUsuarios.Insertar(nuevoUsuario);

                if (resultado == "ok")
                {
                    MessageBox.Show("Usuario insertado correctamente.");
                    this.Close();  // Cierra el formulario después de guardar
                }
                else
                {
                    MessageBox.Show("Error al insertar el usuario.");
                }
            }
        }
    }
    }

