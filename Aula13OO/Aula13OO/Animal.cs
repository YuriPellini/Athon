using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13OO
{
    public abstract class Animal
    {
        //Caracteristicas do objeto
        public string Nome { get; set; }
        public double Tamanho { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }
        //Métodos de valor do bjeto
        public Animal() { }
        public Animal(string nome, double tamanho, double peso, int idade)
        {
            Nome = nome;
            Tamanho = tamanho;
            Peso = peso;
            Peso = idade;
        }
        //Métodos do objeto
        public void ApresentarAnimal()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Tamanho: {Tamanho}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine();
            EmitirSom();
            Console.WriteLine();
        }
        public virtual void EmitirSom() { }
    }
}
