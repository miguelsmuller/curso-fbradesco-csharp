using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBradesco
{
    class Introducao
    {
        public void Run()
        {
            Console.WriteLine("Hello, World!");

            int x = 4;
            double y = 3.3;
            const double frequencia = 60;

            double area = (x + y) * frequencia;

            Console.WriteLine(area);

            Console.WriteLine("Digite qual numero da sua casa: ");
            string numeroCasa = Console.ReadLine();

            if (String.IsNullOrEmpty(numeroCasa))
            {
                numeroCasa = "58";
            }

            int numero = int.Parse(numeroCasa);

            Console.WriteLine("Numero é {0}", numero);

            double V1 = 20.232;
            Console.WriteLine(V1.ToString("F1"));
            Console.WriteLine(V1.ToString("C"));
            Console.WriteLine(V1.ToString("P"));

            // Parte 2 do curso de introdução

            Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Nota maior que 7? {0}", nota > 7.0);
            Console.WriteLine("Tirou 10? {0}", nota == 10.0);
        }
    }
}
