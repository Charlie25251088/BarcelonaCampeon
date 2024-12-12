using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox no está vacío
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                // Agregar la tarea al ListBox
                lstTareas.Items.Add(txtTarea.Text);

                // Limpiar el TextBox después de agregar la tarea
                txtTarea.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una tarea.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            // Verificar si hay una tarea seleccionada
            if (lstTareas.SelectedIndex != -1)
            {
                // Eliminar la tarea seleccionada
                lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lstTareas.Items.Clear();
        }
    }
}
