using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBradesco
{
    class Carro
    {
        public string Nome;
        public string Marca;
        public double Potencia;

        public Carro(string nome, string marca, double potencia)
        {
            Nome = nome;
            Marca = marca;
            Potencia = potencia;
        }

        public Carro() { }
    }
}
