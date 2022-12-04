using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace POO_no_Dotnet.Models
{
    public class Aluno : Pessoa
    {
        public Double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, tenho {Idade} anos, e minha minha nota está em {Nota} atualmente !!");
        }
    }
}