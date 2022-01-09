using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBradesco
{
    class Query
    {
        public void Run()
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var operacao = numeros.Where(x => x % 2 == 0);

            foreach (int x in operacao)
            {
                Console.WriteLine(x);
            }
        }
    }
}
