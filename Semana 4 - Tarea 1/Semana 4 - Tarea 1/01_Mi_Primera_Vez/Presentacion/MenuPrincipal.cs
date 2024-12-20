using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void btnPerosnal_Click(object sender, EventArgs e)
        {
            CUPersonal frmPrueba = new CUPersonal();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);
            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CUUsuarios frmPrueba1 = new CUUsuarios();
            PanelGeneral.Controls.Clear();
            frmPrueba1.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Asistencias.frmAsistencias frmAsistencias = new Asistencias.frmAsistencias();
            frmAsistencias.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

