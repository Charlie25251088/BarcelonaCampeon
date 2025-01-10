using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_Vehiculos.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        private CUClientes cuClientes = new CUClientes();
        private CUVehiculos cuVehiculos = new CUVehiculos();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Limpia el panel y muestra el control CUClientes
            panel3.Controls.Clear();
            cuClientes.Dock = DockStyle.Fill;
            panel3.Controls.Add(cuClientes);

            // Carga los datos en el DataGridView
            cuClientes.CargarDatos();
        }

        private void btn_Vehiculos_Click(object sender, EventArgs e)
        {
            CUVehiculos cuVehiculos = new CUVehiculos();
            cuVehiculos.Dock = DockStyle.Fill;  // Ajusta el tamaño para que ocupe todo el panel
            panel3.Controls.Clear();  // Limpia los controles anteriores
            panel3.Controls.Add(cuVehiculos);  // Agrega el control CUVehiculos al panel

            // Carga los datos en el DataGridView
            cuVehiculos.CargarVehiculos();
        }


    }
}
