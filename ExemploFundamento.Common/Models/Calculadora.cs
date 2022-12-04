using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamento.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza a soma de dois números inteiros 
        /// </summary>
        /// <param name="x">O primeiro número inteiro para somar</param>
        /// <param name="y">O segundo número inteiro para somar</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Dividir(float x, float y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Multiplicar (int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void RestoDeDivisão(int x, int y)
        {
            Console.WriteLine($"{x} % {y} = {x % y}");
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($" Seno de {angulo}° = {Math.Round(seno, 4)}");
        }
         public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($" coseno de {angulo}° = {Math.Round (coseno, 4)}");
        }
         public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($" tangente de {angulo}° = {Math.Round (tangente, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}