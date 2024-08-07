using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_CSharp.Models
{
    public class Pessoa
    {

        private string _nome;
        private int _idade;


        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if(value == ""){
                    throw new ArgumentException("O nome não pode estar vasio!");
                }
                
                    _nome = value;
                
                
            } 
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto 
        { 
            get => $"{Nome} { Sobrenome}".ToUpper();
        }
        public int Idade 
        { 
            get => _idade;
            set{
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {NomeCompleto}, tenho {Idade} anos.");
        }
    }
}