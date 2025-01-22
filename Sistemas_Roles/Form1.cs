using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemas_Roles.Logica;
using Sistemas_Roles.Presentacion;

namespace Sistemas_Roles
{
    public partial class FrmLogin : Form
    {
        private account_controller cuentas_acceso = new account_controller();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = cuentas_acceso.login(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim());
            if (usuario.Detalle_Rol == null)
            {
                MessageBox.Show("El usuario o la contrasenia son incorrectas");
            }
            else
            {
                MessageBox.Show("Bienvenido al sistema");
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Hide(); // Oculta el formulario de login

                // Cerrar completamente la aplicación si se cierra FrmMenuPrincipal
                frmMenuPrincipal.FormClosed += (s, args) => Application.Exit();
            }

            
        }
    }
}
