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
    public partial class FormInsertar : Form
    {

        List<Persona> refListaPersonas;

        public FormInsertar()
        {
            InitializeComponent();
        }

        public FormInsertar(List<Persona> lp) {
            InitializeComponent();
            this.refListaPersonas = lp;
        }

        private void B_Insertar_Click(object sender, EventArgs e) {
            Boolean estaRepetido = false;
            foreach(Persona per in refListaPersonas)
            {
                if (text_dni.Text.Equals(per.Dni))
                {
                    estaRepetido = true;
                }
            }
            if (estaRepetido == false)
            {
                if (text_peso.Text == "")
                {
                    text_peso.Text = "0";
                }
                if (text_altura.Text == "")
                {
                    text_altura.Text = "0";
                }
                Persona p = new Persona(text_dni.Text, text_nombre.Text, text_apellidos.Text, text_fecha.Text, float.Parse(text_peso.Text), float.Parse(text_altura.Text));
                refListaPersonas.Add(p);
                MessageBox.Show("Persona introducida con éxito.");
            }
            else
            {
                MessageBox.Show("Este DNI ya ha sido introducido.");
            }
            
        }
    }
}
