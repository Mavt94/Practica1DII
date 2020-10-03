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
    public partial class FormMostrar : Form
    {
        List<Persona> refLista;

        public FormMostrar()
        {
            InitializeComponent();
        }

        public FormMostrar(List<Persona> lp)
        {
            InitializeComponent();
            this.refLista = lp;
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            dgPersonas.DataSource = refLista;
        }
    }
}
