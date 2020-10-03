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
    public partial class FormIncompletos : Form
    {
        List<Persona> refLista;
        

        public FormIncompletos()
        {
            InitializeComponent();
        }

        public FormIncompletos(List<Persona> lp)
        {
            InitializeComponent();
            this.refLista = lp;
        }

        private void FormIncompletos_Load(object sender, EventArgs e)
        {
            List<Persona> listaIncompletos = new List<Persona>();
            foreach (Persona p in refLista)
            {
                if(p.Dni.Equals("") || p.Nombre.Equals("") || p.Apellidos.Equals("") || p.Fec_nac.Equals("") || p.Peso.Equals("0") || p.Altura.Equals("0"))
                {
                    listaIncompletos.Add(p);
                }
            }

            dgIncompletos.DataSource = listaIncompletos;
            
        }
    }
}
