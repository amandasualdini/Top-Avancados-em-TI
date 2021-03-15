using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    class Idade
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;


            Console.WriteLine("------ Transformando anos em dias --------");


            Console.WriteLine(" ");
            Console.Write("Escreva sua idade (Somente os anos): ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Escreva sua idade (Somente os Meses): ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Escreva sua idade (Somente os dias): ");
            C = Convert.ToInt32(Console.ReadLine());


            C = (C + (A * 365) + (B * 30));

            Console.WriteLine("Sua idade em dias é: " + C);
            System.Console.ReadKey();
        }

    }

}
