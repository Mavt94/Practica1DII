using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class FormMenu : Form
    {

        List<Persona> listaPersonas = new List<Persona>();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void button_Insertar_Click(object sender, EventArgs e) {
            FormInsertar f2 = new FormInsertar(listaPersonas);
            f2.Show();
        }

        private void button_Mostrar_Click(object sender, EventArgs e) {
            FormMostrar f3 = new FormMostrar(listaPersonas);
            f3.Show();
        }

        private void button_ConsultarDni_Click(object sender, EventArgs e) {
            FormDni f4 = new FormDni(listaPersonas);
            f4.Show();
        }

        private void button_MostrarLargo_Click(object sender, EventArgs e) {
            int j = listaPersonas.Count;
            if (j >= 3)
            {
                FormMasLargos f5 = new FormMasLargos(listaPersonas);
                f5.Show();
            }
            else
            {
                MessageBox.Show("Hay sólo "+j+" personas registradas. Introduzca "+(3-j)+" personas más para realizar esta acción.");
            } 
        }

        private void button_FaltanDatos_Click(object sender, EventArgs e) {
            FormIncompletos f6 = new FormIncompletos(listaPersonas);
            f6.Show();
        }

        private void button_Salir_Click(object sender, EventArgs e) {

            var a = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes) {
                Close();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }

}
