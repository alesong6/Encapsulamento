using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    class SubCelebridade {
        //esse atributo é acessado por todos 
        public string InfoPublica = "Tenho Instagram";

        //esse segundo atributo é transmitido por herança 
        protected string CorDoOlho = "Castanho";

        //só pode acessar se for do mesmo projeto
        internal ulong NumeroCelular = 5511947928788;

        // atributo transmitindo por herença ou no mesmo projeto
        protected internal string JeitoDeFalar = "Fala muitas falacias";

        //somente pode ser transmitido no mesmo projeto ou por herança(assembly)
        private protected string Segredo = "Joga no Tigrinho";

        //atributo somente visivel somente nessa classe, é um segredo e ninguem mais pode saber, a não ser a propria pessoa
        private bool PegaAsMeninasDoEmed = true;

        public void MeusAcessos() {
            Console.WriteLine("Pedro: ");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(Segredo);
            Console.WriteLine(PegaAsMeninasDoEmed);
        }

    }
}
