﻿namespace tarea
{
    partial class Form2
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombcredito = new System.Windows.Forms.TextBox();
            this.txttasaint = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtedadmax = new System.Windows.Forms.TextBox();
            this.txtmontomax = new System.Windows.Forms.TextBox();
            this.txtmontomin = new System.Windows.Forms.TextBox();
            this.txtsueldomin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(46, 48);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del credito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo del credito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tasa de interes";
            // 
            // txtnombcredito
            // 
            this.txtnombcredito.Location = new System.Drawing.Point(46, 123);
            this.txtnombcredito.Name = "txtnombcredito";
            this.txtnombcredito.Size = new System.Drawing.Size(100, 20);
            this.txtnombcredito.TabIndex = 6;
            // 
            // txttasaint
            // 
            this.txttasaint.Location = new System.Drawing.Point(46, 201);
            this.txttasaint.Name = "txttasaint";
            this.txttasaint.Size = new System.Drawing.Size(100, 20);
            this.txttasaint.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edad maxima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Monto maximo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Monto minimo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sueldo minimo";
            // 
            // txtedadmax
            // 
            this.txtedadmax.Location = new System.Drawing.Point(217, 48);
            this.txtedadmax.Name = "txtedadmax";
            this.txtedadmax.Size = new System.Drawing.Size(100, 20);
            this.txtedadmax.TabIndex = 12;
            // 
            // txtmontomax
            // 
            this.txtmontomax.Location = new System.Drawing.Point(217, 123);
            this.txtmontomax.Name = "txtmontomax";
            this.txtmontomax.Size = new System.Drawing.Size(100, 20);
            this.txtmontomax.TabIndex = 13;
            // 
            // txtmontomin
            // 
            this.txtmontomin.Location = new System.Drawing.Point(217, 201);
            this.txtmontomin.Name = "txtmontomin";
            this.txtmontomin.Size = new System.Drawing.Size(100, 20);
            this.txtmontomin.TabIndex = 14;
            // 
            // txtsueldomin
            // 
            this.txtsueldomin.Location = new System.Drawing.Point(46, 264);
            this.txtsueldomin.Name = "txtsueldomin";
            this.txtsueldomin.Size = new System.Drawing.Size(100, 20);
            this.txtsueldomin.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 103);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsueldomin);
            this.Controls.Add(this.txtmontomin);
            this.Controls.Add(this.txtmontomax);
            this.Controls.Add(this.txtedadmax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttasaint);
            this.Controls.Add(this.txtnombcredito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigo);
            this.Name = "Form2";
            this.Text = "Registro de creditos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombcredito;
        private System.Windows.Forms.TextBox txttasaint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtedadmax;
        private System.Windows.Forms.TextBox txtmontomax;
        private System.Windows.Forms.TextBox txtmontomin;
        private System.Windows.Forms.TextBox txtsueldomin;
        private System.Windows.Forms.Button button1;
    }
}