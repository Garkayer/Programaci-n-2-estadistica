﻿namespace Programación_2_estadistica
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
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.btnCalcularEstandar = new System.Windows.Forms.Button();
            this.btnCalcularTipica = new System.Windows.Forms.Button();
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
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(13, 79);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(12, 13);
            this.lblRespuesta.TabIndex = 2;
            this.lblRespuesta.Text = "x̄";
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.Location = new System.Drawing.Point(16, 129);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnMediaAritmetica.TabIndex = 3;
            this.btnMediaAritmetica.Text = "Calcular x̄";
            this.btnMediaAritmetica.UseVisualStyleBackColor = true;
            this.btnMediaAritmetica.Click += new System.EventHandler(this.btnMediaAritmetica_Click);
            // 
            // btnCalcularEstandar
            // 
            this.btnCalcularEstandar.Location = new System.Drawing.Point(97, 129);
            this.btnCalcularEstandar.Name = "btnCalcularEstandar";
            this.btnCalcularEstandar.Size = new System.Drawing.Size(121, 23);
            this.btnCalcularEstandar.TabIndex = 4;
            this.btnCalcularEstandar.Text = "Calcular Estandar";
            this.btnCalcularEstandar.UseVisualStyleBackColor = true;
            this.btnCalcularEstandar.Click += new System.EventHandler(this.btnCalcularEstandar_Click);
            // 
            // btnCalcularTipica
            // 
            this.btnCalcularTipica.Location = new System.Drawing.Point(12, 174);
            this.btnCalcularTipica.Name = "btnCalcularTipica";
            this.btnCalcularTipica.Size = new System.Drawing.Size(107, 23);
            this.btnCalcularTipica.TabIndex = 5;
            this.btnCalcularTipica.Text = "Calcular Tipica";
            this.btnCalcularTipica.UseVisualStyleBackColor = true;
            this.btnCalcularTipica.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalcularTipica);
            this.Controls.Add(this.btnCalcularEstandar);
            this.Controls.Add(this.btnMediaAritmetica);
            this.Controls.Add(this.lblRespuesta);
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
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnMediaAritmetica;
        private System.Windows.Forms.Button btnCalcularEstandar;
        private System.Windows.Forms.Button btnCalcularTipica;
    }
}

