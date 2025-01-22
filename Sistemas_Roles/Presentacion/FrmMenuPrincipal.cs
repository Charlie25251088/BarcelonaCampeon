using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemas_Roles.Presentacion;

namespace Sistemas_Roles.Presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private CUUsuarios cuUsuarios = new CUUsuarios();
        private CURoles cuRoles = new CURoles();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            cuRoles.Dock = DockStyle.Fill;
            panel3.Controls.Add(cuRoles);

            cuRoles.CargarRoles();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Limpia el panel y muestra el control CUClientes
            panel3.Controls.Clear();
            cuUsuarios.Dock = DockStyle.Fill;
            panel3.Controls.Add(cuUsuarios);

            cuUsuarios.CargarUsuarios();
        }
    }
}
