using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    class porcentagemRevendedora
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu salário: ");
            double salario =  double.Parse(Console.ReadLine());

            Console.Write("Informe o seu salário: ");
            double salario =  double.Parse(Console.ReadLine());

            Console.Write("Informe o nº de carros vendidos: "); 
            int qtdCarro = int. Parse(Console.ReadLine());

            Console.Write("Informe o val or total das vendas: ");
            double valorTotalVendas =  double.Parse(Console.ReadLine());

            Console.Write("Informe o val or da comissão por carro vendido: "); 
            double valorComissaoFixa =  double.Parse(Console.ReadLine());

            double comissaoFixaFinal = qtdCarro * valorComissao Fixa;
            double comissaoPercentual = valorTotalVendas * 0.05 ;

            double salarioFinal = comissaoFixaFinal + comissaoP ercentual + salario;
            Console.WriteLine("O salario final é {0:C}", salarioFinal);


        }
    }
}
