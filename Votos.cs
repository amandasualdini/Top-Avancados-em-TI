using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex2
    {
        static void Main(string[] args)
        {
            // Declarando Variaveis , e coletando informãções 


            Console.WriteLine("Digite O Total de Votos:");
            int totalvotos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite O Total de Votos brancos:");
            int votosBrancos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite O Total de Votos nulos:");
            int votosNulos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite O Total de Votos validos:");
            int votosValidos = Convert.ToInt32(Console.ReadLine());

            // calculo

            double percentualVotosBrancos = (votosBrancos * 100) / totalvotos;
            double percentualVotosNulos = (votosNulos * 100) / totalvotos;
            double percentualVotosValidos = (votosValidos * 100) / totalvotos;

            //inprimindo valores 

            Console.WriteLine(" O percentual de votos brancos foi: " + percentualVotosBrancos.ToString() + "%");
            Console.WriteLine(" O percentual de votos nulos foi: " + percentualVotosNulos.ToString() + "%");
            Console.WriteLine(" O percentual de votos validos  foi: " + percentualVotosValidos.ToString() + "%");

            Console.ReadKey();

        }
    }
}
