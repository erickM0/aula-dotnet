using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_CSharp.Models
{
    //classe Pessoa
    public class Pessoa
    {
        // Construtor 1
        public Pessoa (){

        }

        // Construtor 2
        public Pessoa (string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Construtor 3
        public Pessoa (string nome, string sobrenome, int idade){
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        //Campo (variaveis privadas da classe)
        private string _nome;
        private int _idade;

        // Propriedade com validação de dados na entrada
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

        //Propriedade apenas leitura
        public string NomeCompleto 
        { 
            get => $"{Nome} { Sobrenome}".ToUpper();
        }

        //Propriedade idade com validação de dados na entrada
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

        //Metodo para apresentar o nome completo e a idade 
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {NomeCompleto}, tenho {Idade} anos.");
        }
    }
}