using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _02_Mi_Segunda_Vez.Presentacion.NewFolder1;

namespace _02_Mi_Segunda_Vez.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMostrar pruebas = new FrmMostrar();
            pruebas.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            /*
            black
            green
            white

                0-255   0-255       0-255
            rgb (red    , green,    blue)

                25      200     0       0 - 1         
            rgba(red,   green,  blue,   transparencia)


            */

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUPersonal frmPrueba = new CUPersonal();
            PanelGeneral.Controls.Clear();
            PanelGeneral.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
