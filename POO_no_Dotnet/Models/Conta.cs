using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_no_Dotnet.Models
{
    public abstract class Conta
    {
        protected decimal Saldo;

        public abstract void Creditar(decimal valor);
        
        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + Saldo);
        }
        
    }
}