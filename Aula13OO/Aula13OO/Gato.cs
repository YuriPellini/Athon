using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13OO
{
    public sealed class Gato : Animal
    {
        //Mudança no método
        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("Miau");
        }
        public Gato(string nome, double tamanho, double peso, int idade) : base(nome, tamanho, peso, idade) { }
    }
}
