using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_no_Dotnet.Models
{
    // o comando sealed serve para quando não quiser que uma classe tenha classes filhas
    // se usado nos metados, esse mesmo metado não pode ser mudado 
    public class Professor  : Pessoa
    {
        public Decimal Salario { get; set; }

        public  override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, tenho {Idade} anos, e meu salário atualmente é {Salario} reais !!");
        }
    }
}