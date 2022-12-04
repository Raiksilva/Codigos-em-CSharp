using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_no_Dotnet.Models
{
    public class Pessoa
    {
        public Pessoa()
        { 

        }
        public Pessoa(string Nome, string Sobrenome)
        {

        }
        private string _Nome;
        private int _Idade;

        public string Nome 
        {
            get => _Nome.ToUpper();

            set
            {
                if(_Nome == "")
                {
                    Console.WriteLine("O nome não pode ser vazio");
                }
                _Nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _Idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("O valor da idade não pode ser Menor que zero(0)");
                }
                _Idade = value;
            }
        }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {NomeCompleto} e tenho {Idade} anos!");
        }
    }
}