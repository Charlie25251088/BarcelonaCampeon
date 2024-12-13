using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pubs.Presentacion.FrmMostrar;

namespace Pubs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAuthors pruebas = new FrmAuthors();
            pruebas.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDiscounts pruebas = new FrmDiscounts();
            pruebas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEmployee pruebas = new FrmEmployee();
            pruebas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmJobs pruebas = new frmJobs();
            pruebas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPubInfo pruebas = new FrmPubInfo();
            pruebas.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPublishers pruebas = new FrmPublishers();
            pruebas.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmRoysched pruebas = new FrmRoysched();
            pruebas.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmSales pruebas = new FrmSales();
            pruebas.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmStores pruebas = new FrmStores();
            pruebas.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmTitleAuthor pruebas = new FrmTitleAuthor();
            pruebas.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmTitles pruebas = new FrmTitles();
            pruebas.Show();
        }
    }
}
