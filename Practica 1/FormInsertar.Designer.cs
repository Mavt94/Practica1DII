namespace Practica_1
{
    partial class FormInsertar
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_altura = new System.Windows.Forms.TextBox();
            this.text_peso = new System.Windows.Forms.TextBox();
            this.text_fecha = new System.Windows.Forms.TextBox();
            this.text_apellidos = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.B_Insertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "DNI";
            // 
            // text_altura
            // 
            this.text_altura.Location = new System.Drawing.Point(158, 180);
            this.text_altura.Name = "text_altura";
            this.text_altura.Size = new System.Drawing.Size(297, 22);
            this.text_altura.TabIndex = 23;
            // 
            // text_peso
            // 
            this.text_peso.Location = new System.Drawing.Point(158, 152);
            this.text_peso.Name = "text_peso";
            this.text_peso.Size = new System.Drawing.Size(297, 22);
            this.text_peso.TabIndex = 22;
            // 
            // text_fecha
            // 
            this.text_fecha.Location = new System.Drawing.Point(158, 122);
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(297, 22);
            this.text_fecha.TabIndex = 21;
            // 
            // text_apellidos
            // 
            this.text_apellidos.Location = new System.Drawing.Point(158, 94);
            this.text_apellidos.Name = "text_apellidos";
            this.text_apellidos.Size = new System.Drawing.Size(297, 22);
            this.text_apellidos.TabIndex = 20;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(158, 66);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(297, 22);
            this.text_nombre.TabIndex = 19;
            // 
            // text_dni
            // 
            this.text_dni.Location = new System.Drawing.Point(158, 35);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(297, 22);
            this.text_dni.TabIndex = 18;
            // 
            // B_Insertar
            // 
            this.B_Insertar.Location = new System.Drawing.Point(337, 208);
            this.B_Insertar.Name = "B_Insertar";
            this.B_Insertar.Size = new System.Drawing.Size(118, 50);
            this.B_Insertar.TabIndex = 30;
            this.B_Insertar.Text = "Insertar";
            this.B_Insertar.UseVisualStyleBackColor = true;
            this.B_Insertar.Click += new System.EventHandler(this.B_Insertar_Click);
            // 
            // FormInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 287);
            this.Controls.Add(this.B_Insertar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_altura);
            this.Controls.Add(this.text_peso);
            this.Controls.Add(this.text_fecha);
            this.Controls.Add(this.text_apellidos);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.text_dni);
            this.Name = "FormInsertar";
            this.Text = "Insertar Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_altura;
        private System.Windows.Forms.TextBox text_peso;
        private System.Windows.Forms.TextBox text_fecha;
        private System.Windows.Forms.TextBox text_apellidos;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.TextBox text_dni;
        private System.Windows.Forms.Button B_Insertar;
    }
}