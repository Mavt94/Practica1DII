using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1 {
    public class Persona : IComparable<Persona>
    {
        
        //Atributos
        string dni;
        string nombre;
        string apellidos;
        string fec_nac;
        float peso;
        float altura;

        //Metodos
        public Persona(string dni, string nombre, string apellidos, string fec_nac, float peso, float altura)  {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fec_nac = fec_nac;
            this.peso = peso;
            this.altura = altura;
        }
        public Persona() {

        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fec_nac { get => fec_nac; set => fec_nac = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Altura { get => altura; set => altura = value; }

        public override string ToString() {
            return "DNI: "+dni+", Nombre: "+nombre+", Apellidos: "+apellidos+", Fecha Nacimiento: "+fec_nac+", Peso: "+peso+", Altura: "+altura+"\n";
        }

        public int CompareTo(Persona other)
        {
            if (this.nombre.Length > other.nombre.Length)
                return -1;
            else if (this.nombre.Length < other.nombre.Length)
                return 1;
            else
                return 0;
        }


    }

}
