using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Recebe as Variaveis
            string nome;
            string sexo;
            double altura, peso, imc;

           
           // Pega o Alvo
            Console.Write("Digite seu nome : ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sexo : ");
            sexo = Console.ReadLine();

            Console.Write("Digite Sua Altura : ");
            altura = Double.Parse(Console.ReadLine());

            Console.Write("Digite o seu peso :");
            peso = Double.Parse(Console.ReadLine());

            if (sexo == "masculino")
            pesoIdealM = (72.7 * altura) - 58
            Console.WriteLine("Seu peso ideal é: " + pesoIdealM);

            else if (sexo == "feminino")
            pesoIdealF = (62.1 * altura) - 44.7
            Console.WriteLine("Seu peso ideal é: " + pesoIdealF);

            else
            { Console.WriteLine("\n\nNão Reconhecido"); }
            
            Console.ReadKey();
        }

    }
}