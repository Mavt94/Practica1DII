namespace Practica_1
{
    partial class FormDni
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.B_Consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el DNI:";
            // 
            // text_dni
            // 
            this.text_dni.Location = new System.Drawing.Point(167, 53);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(163, 22);
            this.text_dni.TabIndex = 1;
            // 
            // B_Consultar
            // 
            this.B_Consultar.Location = new System.Drawing.Point(233, 81);
            this.B_Consultar.Name = "B_Consultar";
            this.B_Consultar.Size = new System.Drawing.Size(97, 32);
            this.B_Consultar.TabIndex = 2;
            this.B_Consultar.Text = "Consultar";
            this.B_Consultar.UseVisualStyleBackColor = true;
            this.B_Consultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 150);
            this.Controls.Add(this.B_Consultar);
            this.Controls.Add(this.text_dni);
            this.Controls.Add(this.label1);
            this.Name = "FormDni";
            this.Text = "Consultar por DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_dni;
        private System.Windows.Forms.Button B_Consultar;
    }
}