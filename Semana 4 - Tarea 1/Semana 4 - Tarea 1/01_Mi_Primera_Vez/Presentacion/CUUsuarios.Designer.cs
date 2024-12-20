namespace _01_Mi_Primera_Vez.Presentacion
{
    partial class CUUsuarios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUbuscar = new System.Windows.Forms.TextBox();
            this.btnUnuevo = new System.Windows.Forms.Button();
            this.btnUbuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUeliminar = new System.Windows.Forms.Button();
            this.btnUeditar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtUbuscar);
            this.panel1.Controls.Add(this.btnUnuevo);
            this.panel1.Controls.Add(this.btnUbuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 140);
            this.panel1.TabIndex = 0;
            // 
            // txtUbuscar
            // 
            this.txtUbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbuscar.Location = new System.Drawing.Point(115, 70);
            this.txtUbuscar.Name = "txtUbuscar";
            this.txtUbuscar.Size = new System.Drawing.Size(189, 29);
            this.txtUbuscar.TabIndex = 2;
            // 
            // btnUnuevo
            // 
            this.btnUnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnuevo.Location = new System.Drawing.Point(648, 58);
            this.btnUnuevo.Name = "btnUnuevo";
            this.btnUnuevo.Size = new System.Drawing.Size(120, 50);
            this.btnUnuevo.TabIndex = 1;
            this.btnUnuevo.Text = "Nuevo Usuario";
            this.btnUnuevo.UseVisualStyleBackColor = true;
            this.btnUnuevo.Click += new System.EventHandler(this.btnUnuevo_Click_1);
            // 
            // btnUbuscar
            // 
            this.btnUbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbuscar.Location = new System.Drawing.Point(442, 58);
            this.btnUbuscar.Name = "btnUbuscar";
            this.btnUbuscar.Size = new System.Drawing.Size(121, 50);
            this.btnUbuscar.TabIndex = 0;
            this.btnUbuscar.Text = "Buscar";
            this.btnUbuscar.UseVisualStyleBackColor = true;
            this.btnUbuscar.Click += new System.EventHandler(this.btnUbuscar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 115);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUeliminar);
            this.panel3.Controls.Add(this.btnUeditar);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1052, 349);
            this.panel3.TabIndex = 2;
            // 
            // btnUeliminar
            // 
            this.btnUeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUeliminar.Location = new System.Drawing.Point(648, 156);
            this.btnUeliminar.Name = "btnUeliminar";
            this.btnUeliminar.Size = new System.Drawing.Size(126, 52);
            this.btnUeliminar.TabIndex = 2;
            this.btnUeliminar.Text = "Eliminar";
            this.btnUeliminar.UseVisualStyleBackColor = true;
            this.btnUeliminar.Click += new System.EventHandler(this.btnUeliminar_Click);
            // 
            // btnUeditar
            // 
            this.btnUeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUeditar.Location = new System.Drawing.Point(648, 76);
            this.btnUeditar.Name = "btnUeditar";
            this.btnUeditar.Size = new System.Drawing.Size(127, 55);
            this.btnUeditar.TabIndex = 1;
            this.btnUeditar.Text = "Editar";
            this.btnUeditar.UseVisualStyleBackColor = true;
            this.btnUeditar.Click += new System.EventHandler(this.btnUeditar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1052, 349);
            this.dataGridView2.TabIndex = 0;
            // 
            // CUUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CUUsuarios";
            this.Size = new System.Drawing.Size(1052, 604);
            this.Load += new System.EventHandler(this.CUUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUnuevo;
        private System.Windows.Forms.Button btnUbuscar;
        private System.Windows.Forms.TextBox txtUbuscar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUeliminar;
        private System.Windows.Forms.Button btnUeditar;
    }
}
