using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicio
            Console.WriteLine("");
            //Cachorro
            Cachorro Robson = new Cachorro("Robson", 15, 12.5, 7);
            Robson.ApresentarAnimal();
            //Gato
            Gato Vanderlei = new Gato("Vanderlei", 13, 11, 9);
            Vanderlei.ApresentarAnimal();
            //Galinha
            Galinha DonaElizabeth = new Galinha("Dona Elizabeth", 20, 50, 4);
            DonaElizabeth.ApresentarAnimal();
            //Fim
            Console.ReadKey();
        }
    }
}
