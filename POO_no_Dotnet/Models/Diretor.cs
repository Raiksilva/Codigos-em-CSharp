using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_no_Dotnet.Models
{
    public class Diretor : Professor
    {
         public override void Apresentar()
        {
            Console.WriteLine("Diretor");
        }
    }
}