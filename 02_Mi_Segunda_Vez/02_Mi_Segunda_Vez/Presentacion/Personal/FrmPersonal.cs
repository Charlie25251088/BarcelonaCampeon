using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _02_Mi_Segunda_Vez.Logica;

namespace _02_Mi_Segunda_Vez.Presentacion.Personal
{
    public partial class FrmPersonal : Form
    {
        public bool modoEdision = false;
        public FrmPersonal(string modo)
        {
            InitializeComponent();
            if (modo != "n") this.modoEdision = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            if (!this.modoEdision)
            {
                lblFrmPersonal.Text = "Ingreso de nuevo Personal";
            }
            else
            {
                lblFrmPersonal.Text = "Actualización de Personal";
            }

            var listapaises = new cls_pais();
                    
            cmbPais.DataSource = listapaises.leer();
            cmbPais.ValueMember = "idPais";
            cmbPais.DisplayMember = "Detalle";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dto_personal = new Datos.dto_personal()
            {
                Cargo = txtCargo.Text,
                Cedula = txtCedula.Text,
                idPais = (int)cmbPais.SelectedValue,
                Nombres = txtNombre.Text,
                Sueldo = Convert.ToDecimal(txtSalario.Text)
            };

                var cls_personal = new cls_personal();

            if(cls_personal.Insertar(dto_personal)  == "ok")
            {
                MessageBox.Show("Se guardo con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }

            
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
