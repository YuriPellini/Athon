using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13OO
{
    public sealed class Galinha : Animal
    {
        //Mudança no método
        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("Cócóricó");
        }
        public Galinha(string nome, double tamanho, double peso, int idade) : base(nome, tamanho, peso, idade) { }
    }
}
