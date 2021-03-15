using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    class Numeros
    {
        static void Main(string[] args)
        {

            int numero = 0;
            int soma = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Informe Um Numero:");
                numero = int.Parse(Console.ReadLine());


                soma = soma + numero;
            }

            Console.WriteLine("A Soma Total Dos Numeros Lidos É:" + soma);
            Console.ReadKey();
        }
    }
}
