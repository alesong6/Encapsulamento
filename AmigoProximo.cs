using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    internal class AmigoProximo  {

        //amigo próximo vai estar dentro do mesmo projeto
        //porem não vai ter aquela relação de herança
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos() {

            Console.WriteLine("Amigo Próximo... ");
            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDoOlho);
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar.);
            //Console.WriteLine(amigo.Segredo);
            //Console.WriteLine(amigo.PegaAsMeninasDoEmed);
        }
    }
}
