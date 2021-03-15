using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades {
    
    public static class Carro {
        
        public static object carro() {
            Console.WriteLine("Digite o custo em R$: ");
            
            double custo = Console.ReadLine();
            double distribuidor = custo * (28 / 100);
            double imposto = custo * (45 / 100);
            double valorFinal = custo + distribuidor + imposto;
            
             Console.WriteLine(" O Custo Final Ao Consumidor É: R$ " + valorFinal.ToString());

            Console.ReadKey();
        }
               
    }
}
