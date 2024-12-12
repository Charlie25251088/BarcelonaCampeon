using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _02_Mi_Segunda_Vez.Presentacion
{
    public partial class CUPersonal : UserControl
    {
        public CUPersonal()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Personal.FrmPersonal frmpersonal = new Personal.FrmPersonal("n");
            frmpersonal.Text = "Nuevo ingreso de personal";
            frmpersonal.ShowDialog();

        }
    }
}
