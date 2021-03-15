using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    class Media
    {
        static void Main(string[] args)
        {


            double soma = 0;
            int contador = 0;

            for (int i = 15; i <= 100; i++)
            {
                soma += i;
                contador += 1;
            }

            Console.Write("A media aritmetica dos números entre 15 e 100 é: " + (soma / contador));
            Console.ReadKey();
        }
    }
}
