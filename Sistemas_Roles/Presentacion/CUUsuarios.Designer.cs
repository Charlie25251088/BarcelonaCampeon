namespace Sistemas_Roles.Presentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnActualizarU = new System.Windows.Forms.Button();
            this.btnInsertarU = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 104);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminarU);
            this.panel2.Controls.Add(this.btnActualizarU);
            this.panel2.Controls.Add(this.btnInsertarU);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 107);
            this.panel2.TabIndex = 1;
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Location = new System.Drawing.Point(639, 27);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(135, 47);
            this.btnEliminarU.TabIndex = 2;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = true;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // btnActualizarU
            // 
            this.btnActualizarU.Location = new System.Drawing.Point(350, 27);
            this.btnActualizarU.Name = "btnActualizarU";
            this.btnActualizarU.Size = new System.Drawing.Size(135, 47);
            this.btnActualizarU.TabIndex = 1;
            this.btnActualizarU.Text = "Actualizar";
            this.btnActualizarU.UseVisualStyleBackColor = true;
            this.btnActualizarU.Click += new System.EventHandler(this.btnActualizarU_Click);
            // 
            // btnInsertarU
            // 
            this.btnInsertarU.Location = new System.Drawing.Point(85, 27);
            this.btnInsertarU.Name = "btnInsertarU";
            this.btnInsertarU.Size = new System.Drawing.Size(135, 47);
            this.btnInsertarU.TabIndex = 0;
            this.btnInsertarU.Text = "Insertar";
            this.btnInsertarU.UseVisualStyleBackColor = true;
            this.btnInsertarU.Click += new System.EventHandler(this.btnInsertarU_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 363);
            this.panel3.TabIndex = 2;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(880, 363);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // CUUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CUUsuarios";
            this.Size = new System.Drawing.Size(880, 574);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Button btnActualizarU;
        private System.Windows.Forms.Button btnInsertarU;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}
