namespace tarea
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.TXTapellido1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTapellido2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTsliquido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTRUT = new System.Windows.Forms.TextBox();
            this.TXTDV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprof = new System.Windows.Forms.ComboBox();
            this.verificador = new System.Windows.Forms.Label();
            this.fnactxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido paterno";
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(53, 138);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(100, 20);
            this.TXTnombre.TabIndex = 5;
            // 
            // TXTapellido1
            // 
            this.TXTapellido1.Location = new System.Drawing.Point(214, 142);
            this.TXTapellido1.Name = "TXTapellido1";
            this.TXTapellido1.Size = new System.Drawing.Size(100, 20);
            this.TXTapellido1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido materno";
            // 
            // TXTapellido2
            // 
            this.TXTapellido2.Location = new System.Drawing.Point(364, 144);
            this.TXTapellido2.Name = "TXTapellido2";
            this.TXTapellido2.Size = new System.Drawing.Size(100, 20);
            this.TXTapellido2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Profesion ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sueldo liquido";
            // 
            // TXTsliquido
            // 
            this.TXTsliquido.Location = new System.Drawing.Point(364, 180);
            this.TXTsliquido.Name = "TXTsliquido";
            this.TXTsliquido.Size = new System.Drawing.Size(100, 20);
            this.TXTsliquido.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rut";
            // 
            // TXTRUT
            // 
            this.TXTRUT.Location = new System.Drawing.Point(53, 99);
            this.TXTRUT.MaxLength = 10;
            this.TXTRUT.Name = "TXTRUT";
            this.TXTRUT.Size = new System.Drawing.Size(100, 20);
            this.TXTRUT.TabIndex = 17;
            this.TXTRUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTRUT_KeyPress);
            // 
            // TXTDV
            // 
            this.TXTDV.Location = new System.Drawing.Point(179, 99);
            this.TXTDV.MaxLength = 1;
            this.TXTDV.Name = "TXTDV";
            this.TXTDV.Size = new System.Drawing.Size(22, 20);
            this.TXTDV.TabIndex = 18;
            this.TXTDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTDV_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "DV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "-";
            // 
            // txtprof
            // 
            this.txtprof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtprof.FormattingEnabled = true;
            this.txtprof.Location = new System.Drawing.Point(214, 180);
            this.txtprof.Name = "txtprof";
            this.txtprof.Size = new System.Drawing.Size(121, 21);
            this.txtprof.TabIndex = 21;
            // 
            // verificador
            // 
            this.verificador.AutoSize = true;
            this.verificador.Location = new System.Drawing.Point(227, 101);
            this.verificador.Name = "verificador";
            this.verificador.Size = new System.Drawing.Size(0, 13);
            this.verificador.TabIndex = 23;
            // 
            // fnactxt
            // 
            this.fnactxt.Location = new System.Drawing.Point(53, 181);
            this.fnactxt.Name = "fnactxt";
            this.fnactxt.Size = new System.Drawing.Size(100, 20);
            this.fnactxt.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 285);
            this.dataGridView1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 295);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fnactxt);
            this.Controls.Add(this.verificador);
            this.Controls.Add(this.txtprof);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TXTDV);
            this.Controls.Add(this.TXTRUT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTsliquido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTapellido2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTapellido1);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.TextBox TXTapellido1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTapellido2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTsliquido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTRUT;
        private System.Windows.Forms.TextBox TXTDV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtprof;
        private System.Windows.Forms.Label verificador;
        private System.Windows.Forms.TextBox fnactxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

