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

namespace Sistemas_Roles.Presentacion
{
    public partial class FrmInsertarRoles : Form
    {
        private int idRol = 0;
        public FrmInsertarRoles(int id = 0, string detalle = "")
        {
            InitializeComponent();

            if (id > 0)
            {
                idRol = id;
                txtDetalle.Text = detalle;
                btnGuardarR.Text = "Actualizar";
            }
        }

        private void btnGuardarR_Click(object sender, EventArgs e)
        {           
            try
            {
                string detalle = txtDetalle.Text.Trim();

                if (string.IsNullOrWhiteSpace(detalle))
                {
                    MessageBox.Show("Ingrese un detalle para el rol.");
                    return;
                }

                cls_roles rol = new cls_roles();
                bool resultado;

                if (idRol > 0)
                {
                    resultado = rol.ActualizarRol(idRol, detalle);
                }
                else
                {
                    resultado = rol.InsertarRol(detalle);
                }

                if (resultado)
                {
                    MessageBox.Show(idRol > 0 ? "Rol actualizado correctamente." : "Rol insertado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar el rol.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
