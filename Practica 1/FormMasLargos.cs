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
    public partial class FormMasLargos : Form
    {
        List<Persona> refLista;
        List<Persona> listaMasLargos = new List<Persona>();

        public FormMasLargos()
        {
            InitializeComponent();
        }

        public FormMasLargos(List<Persona> lp)
        {
            InitializeComponent();
            this.refLista = lp;
        }

        private void FormMasLargos_Load(object sender, EventArgs e)
        {
            refLista.Sort();
            int i = 0;
            foreach (Persona p in refLista)
            {
                listaMasLargos.Add(p);
                i++;
                if (i >= 3)
                {
                    break;
                }
            }

            dgMasLargos.DataSource = listaMasLargos;
        }
    }
}
