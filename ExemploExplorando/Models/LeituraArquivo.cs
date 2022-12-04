using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinha) LerArquivo(String Caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(Caminho);
                return (true, linhas, linhas.Count());
            }
            catch
            {
                return (false, new string[0], 0);
            }
        }
    }
}