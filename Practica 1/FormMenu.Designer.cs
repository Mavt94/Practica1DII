namespace Practica_1
{
    partial class FormMenu
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
            this.button_Insertar = new System.Windows.Forms.Button();
            this.button_Mostrar = new System.Windows.Forms.Button();
            this.button_ConsultarDni = new System.Windows.Forms.Button();
            this.button_MostrarLargo = new System.Windows.Forms.Button();
            this.button_FaltanDatos = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Insertar
            // 
            this.button_Insertar.Location = new System.Drawing.Point(22, 55);
            this.button_Insertar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Insertar.Name = "button_Insertar";
            this.button_Insertar.Size = new System.Drawing.Size(78, 37);
            this.button_Insertar.TabIndex = 6;
            this.button_Insertar.Text = "Insertar Persona";
            this.button_Insertar.UseVisualStyleBackColor = true;
            this.button_Insertar.Click += new System.EventHandler(this.button_Insertar_Click);
            // 
            // button_Mostrar
            // 
            this.button_Mostrar.Location = new System.Drawing.Point(142, 55);
            this.button_Mostrar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Mostrar.Name = "button_Mostrar";
            this.button_Mostrar.Size = new System.Drawing.Size(78, 37);
            this.button_Mostrar.TabIndex = 7;
            this.button_Mostrar.Text = "Mostrar Listado";
            this.button_Mostrar.UseVisualStyleBackColor = true;
            this.button_Mostrar.Click += new System.EventHandler(this.button_Mostrar_Click);
            // 
            // button_ConsultarDni
            // 
            this.button_ConsultarDni.Location = new System.Drawing.Point(261, 55);
            this.button_ConsultarDni.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConsultarDni.Name = "button_ConsultarDni";
            this.button_ConsultarDni.Size = new System.Drawing.Size(78, 37);
            this.button_ConsultarDni.TabIndex = 8;
            this.button_ConsultarDni.Text = "Consultar por DNI";
            this.button_ConsultarDni.UseVisualStyleBackColor = true;
            this.button_ConsultarDni.Click += new System.EventHandler(this.button_ConsultarDni_Click);
            // 
            // button_MostrarLargo
            // 
            this.button_MostrarLargo.Location = new System.Drawing.Point(22, 110);
            this.button_MostrarLargo.Margin = new System.Windows.Forms.Padding(2);
            this.button_MostrarLargo.Name = "button_MostrarLargo";
            this.button_MostrarLargo.Size = new System.Drawing.Size(78, 37);
            this.button_MostrarLargo.TabIndex = 11;
            this.button_MostrarLargo.Text = "3 Nombres Más Largos";
            this.button_MostrarLargo.UseVisualStyleBackColor = true;
            this.button_MostrarLargo.Click += new System.EventHandler(this.button_MostrarLargo_Click);
            // 
            // button_FaltanDatos
            // 
            this.button_FaltanDatos.Location = new System.Drawing.Point(142, 110);
            this.button_FaltanDatos.Margin = new System.Windows.Forms.Padding(2);
            this.button_FaltanDatos.Name = "button_FaltanDatos";
            this.button_FaltanDatos.Size = new System.Drawing.Size(78, 37);
            this.button_FaltanDatos.TabIndex = 10;
            this.button_FaltanDatos.Text = "Personas Faltan Datos";
            this.button_FaltanDatos.UseVisualStyleBackColor = true;
            this.button_FaltanDatos.Click += new System.EventHandler(this.button_FaltanDatos_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(261, 110);
            this.button_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(78, 37);
            this.button_Salir.TabIndex = 9;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "MENÚ";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_MostrarLargo);
            this.Controls.Add(this.button_FaltanDatos);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_ConsultarDni);
            this.Controls.Add(this.button_Mostrar);
            this.Controls.Add(this.button_Insertar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Insertar;
        private System.Windows.Forms.Button button_Mostrar;
        private System.Windows.Forms.Button button_ConsultarDni;
        private System.Windows.Forms.Button button_MostrarLargo;
        private System.Windows.Forms.Button button_FaltanDatos;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Label label1;
    }
}

