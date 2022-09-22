
namespace PRACTICA8_
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
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.btnmesaje2 = new System.Windows.Forms.Button();
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.btnMensaje1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Location = new System.Drawing.Point(290, 27);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(178, 20);
            this.txtMensaje2.TabIndex = 7;
            // 
            // btnmesaje2
            // 
            this.btnmesaje2.Location = new System.Drawing.Point(290, 70);
            this.btnmesaje2.Name = "btnmesaje2";
            this.btnmesaje2.Size = new System.Drawing.Size(117, 23);
            this.btnmesaje2.TabIndex = 6;
            this.btnmesaje2.Text = "Enviar mensaje 2";
            this.btnmesaje2.UseVisualStyleBackColor = true;
            this.btnmesaje2.Click += new System.EventHandler(this.btnmesaje2_Click);
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.Location = new System.Drawing.Point(31, 27);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(178, 20);
            this.txtMensaje1.TabIndex = 5;
            // 
            // btnMensaje1
            // 
            this.btnMensaje1.Location = new System.Drawing.Point(31, 70);
            this.btnMensaje1.Name = "btnMensaje1";
            this.btnMensaje1.Size = new System.Drawing.Size(117, 23);
            this.btnMensaje1.TabIndex = 4;
            this.btnMensaje1.Text = "Enviar mensaje 1";
            this.btnMensaje1.UseVisualStyleBackColor = true;
            this.btnMensaje1.Click += new System.EventHandler(this.btnMensaje1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 201);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.btnmesaje2);
            this.Controls.Add(this.txtMensaje1);
            this.Controls.Add(this.btnMensaje1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje2;
        private System.Windows.Forms.Button btnmesaje2;
        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.Button btnMensaje1;
    }
}

