using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percentualCarro {
    
    public static class Carro {
        
        public static object carro() {
            Console.WriteLine("Digite o custo em R$: ");
            
            var custo = Console.ReadLine();
            var distribuidor = custo * (28 / 100);
            var imposto = custo * (45 / 100);
            var valorFinal = custo + distribuidor + imposto;
            
            Console.WriteLine("Valor Final R$: " valorFinal);
        }
               
    }
}
