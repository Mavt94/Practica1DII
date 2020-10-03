using System;
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
    public partial class FormDni : Form
    {

        List<Persona> refListaPersonas2;

        public FormDni()
        {
            InitializeComponent();
        }

        public FormDni(List<Persona> lp2)
        {
            InitializeComponent();
            this.refListaPersonas2 = lp2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach(Persona p in refListaPersonas2)
            {
                if (p.Dni.Equals(text_dni.Text))
                {
                    existe = true;
                    MessageBox.Show(p.ToString());
                }
            }
            if (existe == false)
            {
                MessageBox.Show("El DNI introducido no se encuentra guardado.");
            }
        }

    }
}
