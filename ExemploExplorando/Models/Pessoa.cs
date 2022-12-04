using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
 
        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }
        // Deconstruct serve para desconstruir o que foi construido anteriormente.
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = SobreNome;
        }

        private string _nome;
        private int _idade;

        public string Nome { 
            get =>  _nome.ToUpper();
             
            
            set{
                if(value == ""){
                   
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
            
        } 

        public string SobreNome { get; set; }
        public String NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

        public int Idade {

            // => recomentado para quando o comando for simples e pequeno 
            get => _idade;
     
            
            set{
                if(value < 0){
                    throw new ArgumentException("O valor da idade tem que ser superior a zero");
                }
                _idade = value;
            }
            
        }


        public void Apresentar(){
            Console.WriteLine($"Meu nome é {NomeCompleto}, tenho {Idade} anos");
        }
    }
}