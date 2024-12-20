using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Mi_Primera_Vez.Logica;

namespace _01_Mi_Primera_Vez.Presentacion.Personal
{
    public partial class Frmpersonal : Form
    {
        public bool modoEdision = false;
        public int id = 0;
        public Frmpersonal(string modo)
        {
            InitializeComponent();
            if (modo != "n")
            {
                this.modoEdision = true;
                this.id = int.Parse(modo);
            }
        }
        
        private void Frmpersonal_Load(object sender, EventArgs e)
        {
            cargapais();
            if (!this.modoEdision)
            {
                lblFrmPersonal.Text = "Ingreso de Nuevo Personal";
            }
            else { 
                lblFrmPersonal.Text = "Actualziacion de Personal";
                var clspersonal = new cls_personal();
                var personal = clspersonal.uno(this.id);
                txtCargo.Text = personal.cargo;
                txtCedula.Text = personal.cedula;
                txtNombres.Text = personal.nombre;
                txtSalario.Text = personal.sueldo.ToString();
                cmbPais.SelectedValue = personal.idPais;
            }
        }
        public void cargapais() {
            var listapaises = new cls_pais();
            cmbPais.DataSource = listapaises.leer();
            cmbPais.ValueMember = "IdPais";
            cmbPais.DisplayMember = "Detalle";
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == "" || txtCedula.Text == "" || txtNombres.Text == "" || txtSalario.Text == "" )
            {
                MessageBox.Show("Por favor, complete los campos");
                return;
            }
            var dto_personal = new Datos.dto_personal {
            cargo = txtCargo.Text,
            cedula = txtCedula.Text,
            idPais = (int)cmbPais.SelectedValue,
            nombre = txtNombres.Text,
            sueldo = decimal.Parse(txtSalario.Text)
            };
            var cls_personal = new cls_personal();
            try
            {
                if (!this.modoEdision)
                {
                    var valorinsertar = cls_personal.Insertar(dto_personal);
                    if (valorinsertar == "ok") {
                        MessageBox.Show("Se actualizo con exito");
                        this.Close();
                    }
                }
                else
                {
                    dto_personal.IdPersonal = this.id;
                    if (cls_personal.actualizar(dto_personal) == "ok")
                    {
                        MessageBox.Show("Se actualizo con exito");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (this.modoEdision) return;

            var clspersonal = new cls_personal();
            if (clspersonal.duplicadoCedula(txtCedula.Text))
            {
                txtCedula.Focus();
                MessageBox.Show("El numero ingresado ya fue registrado");
                borrar();
            }
        }
        public void borrar() {
            txtCedula.Text = "";
            txtCargo.Text = "";
            txtNombres.Text = "";
            txtSalario.Text = "";
            cmbPais.SelectedIndex = 0;
        }

        private void cmbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPais_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
