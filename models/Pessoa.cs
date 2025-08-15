using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models
{
    public class Pessoa
    {

        //Propriedades
        public string Nome { get; set; } //get; set; é o padrão de propriedade em C# e serve para encapsular o acesso ao campo.
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos "); 
        }
    }
}