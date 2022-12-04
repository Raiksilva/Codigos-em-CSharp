using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_no_Dotnet.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal Saldo;


        public void Sacar(decimal valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponivel");
            }
            
        }
        public void Depositar(decimal valor)
        {
            if(valor > 0)
            {
                valor =+ Saldo;
                Console.WriteLine("deposito realizado com sucesso");
            }
            else
            {
                throw new ArgumentException("Valor negativo");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel é: {Saldo}");
        }
    }
}