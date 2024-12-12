namespace _02_Mi_Segunda_Vez.Presentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.Panel_Bienvenida = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelGeneral.SuspendLayout();
            this.Panel_Bienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(171)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 641);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Control de Asistencia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::_02_Mi_Segunda_Vez.Properties.Resources.png_transparent_time_and_attendance_computer_icons_time_attendance_clocks_computer_software_access_control_time_and_attendance_text_trademark_computer_thumbnail;
            this.pictureBox1.Location = new System.Drawing.Point(0, 417);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Image = global::_02_Mi_Segunda_Vez.Properties.Resources.recuperacion_de_datos;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "Respaldos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Image = global::_02_Mi_Segunda_Vez.Properties.Resources.archivo_de_base_de_datos;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 72);
            this.button3.TabIndex = 3;
            this.button3.Text = "Restaurar BD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Image = global::_02_Mi_Segunda_Vez.Properties.Resources.administracion;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Personal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(124)))));
            this.button1.Image = global::_02_Mi_Segunda_Vez.Properties.Resources.asistencia;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Asistencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(78)))), ((int)(((byte)(109)))));
            this.panel2.Controls.Add(this.btnUsuarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 123);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(184, 53);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.button5_Click);
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.BackColor = System.Drawing.Color.SkyBlue;
            this.PanelGeneral.Controls.Add(this.Panel_Bienvenida);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(184, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(1048, 641);
            this.PanelGeneral.TabIndex = 1;
            // 
            // Panel_Bienvenida
            // 
            this.Panel_Bienvenida.Controls.Add(this.label2);
            this.Panel_Bienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Bienvenida.Location = new System.Drawing.Point(0, 0);
            this.Panel_Bienvenida.Name = "Panel_Bienvenida";
            this.Panel_Bienvenida.Size = new System.Drawing.Size(1048, 120);
            this.Panel_Bienvenida.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1048, 120);
            this.label2.TabIndex = 0;
            this.label2.Text = "BIENVENIDO AL SISTEMA DE CONTROL DE ASISTENCIAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 641);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PanelGeneral.ResumeLayout(false);
            this.Panel_Bienvenida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Bienvenida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUsuarios;
    }
}