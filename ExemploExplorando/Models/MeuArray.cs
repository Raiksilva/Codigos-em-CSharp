using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class MeuArray<T>
    {
        // exemplo de classe genérica 
        private static int Capacidade = 10;
        private int Contador = 0;
        private T[] array = new T[Capacidade];
        

        public void AdicionarElementoArray (T elemento)
        {
            if(Contador + 1 < 11)
            {
                array[Contador] = elemento;
            }
            Contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}