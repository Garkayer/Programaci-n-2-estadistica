namespace Programación_2_estadistica
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
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblRespuesta_Serie = new System.Windows.Forms.Label();
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(13, 33);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(31, 13);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(54, 30);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // lblRespuesta_Serie
            // 
            this.lblRespuesta_Serie.AutoSize = true;
            this.lblRespuesta_Serie.Location = new System.Drawing.Point(13, 79);
            this.lblRespuesta_Serie.Name = "lblRespuesta_Serie";
            this.lblRespuesta_Serie.Size = new System.Drawing.Size(12, 13);
            this.lblRespuesta_Serie.TabIndex = 2;
            this.lblRespuesta_Serie.Text = "x̄";
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.Location = new System.Drawing.Point(16, 129);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnMediaAritmetica.TabIndex = 3;
            this.btnMediaAritmetica.Text = "Calcular x̄";
            this.btnMediaAritmetica.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMediaAritmetica);
            this.Controls.Add(this.lblRespuesta_Serie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblRespuesta_Serie;
        private System.Windows.Forms.Button btnMediaAritmetica;
    }
}

