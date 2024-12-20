using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace _01_Mi_Primera_Vez.Presentacion.Asistencias
{
    public partial class frmAsistencias : Form
    {

        public frmAsistencias()
        {
            InitializeComponent();

        }
            

        public void SetImage(Bitmap bitmap)
        {
            timeBox.Text = DateTime.Now.ToLongTimeString();

            lock (this)
            {
                Bitmap old = (Bitmap)pictureBox.Image;
                pictureBox.Image = bitmap;

                if (old != null)
                {
                    old.Dispose();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var cls_asistencia = new Logica.cls_asistencia();
            var dto_asistecia = new Datos.dto_asistecia();
            var cls_personal = new Logica.cls_personal();

            var personal = cls_personal.uno(txtcedula.Text);
            if (personal.IdPersonal == 0) {
                MessageBox.Show("No se encotro ningun registro con ese numero de cedula");
                return;
            }
            dto_asistecia = new Datos.dto_asistecia
            {
                Cedula = txtcedula.Text,
                IdPersonal = personal.IdPersonal

            };
            if (cls_asistencia.insertar(dto_asistecia))
            {
                MessageBox.Show("La asistencia se registro con exito");
            }
            
        }

        private void frmAsistencias_Load(object sender, EventArgs e)
        {

        }
    }   
}
