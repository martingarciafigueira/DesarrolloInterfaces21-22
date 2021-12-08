
namespace Actividad8_2
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
            this.btnCrearTriangulo = new System.Windows.Forms.Button();
            this.btnCrearCirculo = new System.Windows.Forms.Button();
            this.btnCrearRectangulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearTriangulo
            // 
            this.btnCrearTriangulo.Location = new System.Drawing.Point(333, 132);
            this.btnCrearTriangulo.Name = "btnCrearTriangulo";
            this.btnCrearTriangulo.Size = new System.Drawing.Size(88, 43);
            this.btnCrearTriangulo.TabIndex = 0;
            this.btnCrearTriangulo.Text = "Crear triángulo";
            this.btnCrearTriangulo.UseVisualStyleBackColor = true;
            this.btnCrearTriangulo.Click += new System.EventHandler(this.btnCrearTriangulo_Click);
            // 
            // btnCrearCirculo
            // 
            this.btnCrearCirculo.Location = new System.Drawing.Point(333, 202);
            this.btnCrearCirculo.Name = "btnCrearCirculo";
            this.btnCrearCirculo.Size = new System.Drawing.Size(88, 45);
            this.btnCrearCirculo.TabIndex = 1;
            this.btnCrearCirculo.Text = "Crear círculo";
            this.btnCrearCirculo.UseVisualStyleBackColor = true;
            this.btnCrearCirculo.Click += new System.EventHandler(this.btnCrearCirculo_Click);
            // 
            // btnCrearRectangulo
            // 
            this.btnCrearRectangulo.Location = new System.Drawing.Point(333, 273);
            this.btnCrearRectangulo.Name = "btnCrearRectangulo";
            this.btnCrearRectangulo.Size = new System.Drawing.Size(88, 46);
            this.btnCrearRectangulo.TabIndex = 2;
            this.btnCrearRectangulo.Text = "Crear rectángulo";
            this.btnCrearRectangulo.UseVisualStyleBackColor = true;
            this.btnCrearRectangulo.Click += new System.EventHandler(this.btnCrearRectangulo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearRectangulo);
            this.Controls.Add(this.btnCrearCirculo);
            this.Controls.Add(this.btnCrearTriangulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTriangulo;
        private System.Windows.Forms.Button btnCrearCirculo;
        private System.Windows.Forms.Button btnCrearRectangulo;
    }
}

