namespace GestionTareasPendientes
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.Location = new System.Drawing.Point(320, 72);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(131, 42);
            this.btnAgregarTarea.TabIndex = 0;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTarea.Location = new System.Drawing.Point(328, 349);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(123, 44);
            this.btnEliminarTarea.TabIndex = 1;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // lstTareas
            // 
            this.lstTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.ItemHeight = 20;
            this.lstTareas.Location = new System.Drawing.Point(264, 138);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(244, 184);
            this.lstTareas.TabIndex = 2;
            // 
            // txtTarea
            // 
            this.txtTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarea.Location = new System.Drawing.Point(320, 27);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(142, 26);
            this.txtTarea.TabIndex = 3;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLista.Location = new System.Drawing.Point(583, 210);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(111, 48);
            this.btnLimpiarLista.TabIndex = 4;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 489);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.lstTareas);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnLimpiarLista;
    }
}

