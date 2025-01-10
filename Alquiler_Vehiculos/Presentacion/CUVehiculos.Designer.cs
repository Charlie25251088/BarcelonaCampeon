namespace Alquiler_Vehiculos.Presentacion
{
    partial class CUVehiculos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewVehiculos = new System.Windows.Forms.DataGridView();
            this.btnInsertarV = new System.Windows.Forms.Button();
            this.btnEditarV = new System.Windows.Forms.Button();
            this.btnEliminarV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminarV);
            this.panel1.Controls.Add(this.btnEditarV);
            this.panel1.Controls.Add(this.btnInsertarV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 90);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 97);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewVehiculos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 392);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewVehiculos
            // 
            this.dataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVehiculos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVehiculos.MultiSelect = false;
            this.dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            this.dataGridViewVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVehiculos.Size = new System.Drawing.Size(786, 392);
            this.dataGridViewVehiculos.TabIndex = 0;
            // 
            // btnInsertarV
            // 
            this.btnInsertarV.Location = new System.Drawing.Point(56, 23);
            this.btnInsertarV.Name = "btnInsertarV";
            this.btnInsertarV.Size = new System.Drawing.Size(155, 55);
            this.btnInsertarV.TabIndex = 0;
            this.btnInsertarV.Text = "Insertar";
            this.btnInsertarV.UseVisualStyleBackColor = true;
            this.btnInsertarV.Click += new System.EventHandler(this.btnInsertarV_Click);
            // 
            // btnEditarV
            // 
            this.btnEditarV.Location = new System.Drawing.Point(313, 23);
            this.btnEditarV.Name = "btnEditarV";
            this.btnEditarV.Size = new System.Drawing.Size(155, 55);
            this.btnEditarV.TabIndex = 1;
            this.btnEditarV.Text = "Editar";
            this.btnEditarV.UseVisualStyleBackColor = true;
            this.btnEditarV.Click += new System.EventHandler(this.btnEditarV_Click);
            // 
            // btnEliminarV
            // 
            this.btnEliminarV.Location = new System.Drawing.Point(583, 23);
            this.btnEliminarV.Name = "btnEliminarV";
            this.btnEliminarV.Size = new System.Drawing.Size(155, 55);
            this.btnEliminarV.TabIndex = 2;
            this.btnEliminarV.Text = "Eliminar";
            this.btnEliminarV.UseVisualStyleBackColor = true;
            this.btnEliminarV.Click += new System.EventHandler(this.btnEliminarV_Click);
            // 
            // CUVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CUVehiculos";
            this.Size = new System.Drawing.Size(786, 579);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewVehiculos;
        private System.Windows.Forms.Button btnEliminarV;
        private System.Windows.Forms.Button btnEditarV;
        private System.Windows.Forms.Button btnInsertarV;
    }
}
