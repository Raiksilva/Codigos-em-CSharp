using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_no_Dotnet.interfaces
{
    public interface ICalculadora
    {
        double Somar(double num1, double num2);
        double Subtrair(double num1, double num2);
        double Multiplicar(double num1, double num2);
        double Dividir(double num1, double num2);
    }
}