using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    class porcentagemRevendedora
    {
        static void Main(string[] args)
        {
            int n=0, maior=0;
            
            Console.Write("Informe o primeiro valor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            maior = n;
            
            Console.Write("Informe o segundo valor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            
            if (n > maior)
            {
                maior = n;
            }

            Console.Write("Informe o terceiro valor: "); 
            n = Convert.ToInt32(Console.ReadLine());
            
            if (n > maior)
            {
                maior = n;
            }

            Console.Write("O maior valor é: " +maior);


        }
    }
}