using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_no_Dotnet.interfaces;

namespace POO_no_Dotnet.Models
{
    public class Calculadora : ICalculadora
    {
        
        double ICalculadora.Somar(double num1, double num2)
        {
            return num1 + num2;
        }
        double somar(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        double ICalculadora.Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        double ICalculadora.Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        double ICalculadora.Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}