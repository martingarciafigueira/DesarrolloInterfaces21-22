namespace Actividad9
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
            this.btnCrearLibro = new System.Windows.Forms.Button();
            this.btnCrearDVD = new System.Windows.Forms.Button();
            this.lstPublicaciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtPrecioLibro = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtTituloDVD = new System.Windows.Forms.TextBox();
            this.txtPrecioDVD = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearLibro
            // 
            this.btnCrearLibro.Location = new System.Drawing.Point(90, 367);
            this.btnCrearLibro.Name = "btnCrearLibro";
            this.btnCrearLibro.Size = new System.Drawing.Size(148, 68);
            this.btnCrearLibro.TabIndex = 0;
            this.btnCrearLibro.Text = "Crear libro";
            this.btnCrearLibro.UseVisualStyleBackColor = true;
            this.btnCrearLibro.Click += new System.EventHandler(this.btnCrearLibro_Click);
            // 
            // btnCrearDVD
            // 
            this.btnCrearDVD.Location = new System.Drawing.Point(770, 367);
            this.btnCrearDVD.Name = "btnCrearDVD";
            this.btnCrearDVD.Size = new System.Drawing.Size(165, 68);
            this.btnCrearDVD.TabIndex = 1;
            this.btnCrearDVD.Text = "Crear DVD";
            this.btnCrearDVD.UseVisualStyleBackColor = true;
            this.btnCrearDVD.Click += new System.EventHandler(this.btnCrearDVD_Click);
            // 
            // lstPublicaciones
            // 
            this.lstPublicaciones.FormattingEnabled = true;
            this.lstPublicaciones.ItemHeight = 16;
            this.lstPublicaciones.Location = new System.Drawing.Point(349, 291);
            this.lstPublicaciones.Name = "lstPublicaciones";
            this.lstPublicaciones.Size = new System.Drawing.Size(327, 212);
            this.lstPublicaciones.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(120, 266);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 22);
            this.txtAutor.TabIndex = 7;
            // 
            // txtPrecioLibro
            // 
            this.txtPrecioLibro.Location = new System.Drawing.Point(120, 220);
            this.txtPrecioLibro.Name = "txtPrecioLibro";
            this.txtPrecioLibro.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioLibro.TabIndex = 8;
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(120, 165);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(100, 22);
            this.txtTituloLibro.TabIndex = 9;
            // 
            // txtTituloDVD
            // 
            this.txtTituloDVD.Location = new System.Drawing.Point(835, 167);
            this.txtTituloDVD.Name = "txtTituloDVD";
            this.txtTituloDVD.Size = new System.Drawing.Size(100, 22);
            this.txtTituloDVD.TabIndex = 15;
            // 
            // txtPrecioDVD
            // 
            this.txtPrecioDVD.Location = new System.Drawing.Point(835, 220);
            this.txtPrecioDVD.Name = "txtPrecioDVD";
            this.txtPrecioDVD.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioDVD.TabIndex = 14;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(835, 268);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 22);
            this.txtDuracion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Duracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(736, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(736, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Titulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtTituloDVD);
            this.Controls.Add(this.txtPrecioDVD);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTituloLibro);
            this.Controls.Add(this.txtPrecioLibro);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPublicaciones);
            this.Controls.Add(this.btnCrearDVD);
            this.Controls.Add(this.btnCrearLibro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearLibro;
        private System.Windows.Forms.Button btnCrearDVD;
        private System.Windows.Forms.ListBox lstPublicaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtPrecioLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtTituloDVD;
        private System.Windows.Forms.TextBox txtPrecioDVD;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

