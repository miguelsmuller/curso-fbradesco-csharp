using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBradesco
{
    public static class calculadoraExtensao
    {
        public static double Soma (this double n1, double n2) { 
            return n1 + n2; 
        }
    }

    public static class Extensao
    {
        public static void Run()
        {
            double x = 3;

            Console.WriteLine(x.Soma(7));
            Console.WriteLine(9.2.Soma(7));
        }
    }
}
