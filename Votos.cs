namespace Namespace {
    
    using System.Diagnostics;
    
    public static class Module {
        
        public class Votos
            : object {
            
            public Votos(object total_eleitores) {
                this.total_eleitores = total_eleitores;
                this.validos = 0;
                this.brancos = 0;
                this.nulos = 0;
            }
            
            //<parser-error>
            public virtual object percValidos() {
                return this.validos / this.total_eleitores;
            }
            
            public virtual object percBrancos() {
                return this.brancos / this.total_eleitores;
            }
            
            public virtual object percNulos() {
                return this.nulos / this.total_eleitores;
            }
        }
        
        public static object votos = Votos(1000);
        
        static Module() {
            votos.validos = 800;
            votos.brancos = 150;
            votos.nulos = 50;
        }
    }
}
