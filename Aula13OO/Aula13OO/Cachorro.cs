using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13OO
{
    public sealed class Cachorro : Animal
    {
        //Mudança no método
        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("AU AU");
        }
        public Cachorro(string nome, double tamanho, double peso, int idade) : base(nome, tamanho, peso, idade) { }
    }
}
