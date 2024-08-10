using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_CSharp.Models
{
    // Classe curso
    public class Curso
    {
        //construtor da classe Curso,
        // inicialização da lista  de alunos no construtor
        public Curso(){
            Alunos = new List<Pessoa>();
        }

        //Propriedade Nome
        public string Nome {get; set;}

        //Propriedade Alunos, 
        //se trata de uma Lista de objetos da Classe Pessoas
        // quando se cria uma lista como propriedade
        // é necessário inicializar a lista antes de incluir valires nela.
        // Esse processo pode ser realizado na declaração da propriedade,
        // dentro do construtor da classe ou então 
        // quando estiver utilizando o objeto instanciado(Não indicado) 
        public List<Pessoa> Alunos { get; set; }
    
        //Metodo vazio, que recebe um parametro para incluir alunos na Propriedade Alunos
        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        //Metodo int, que não recebe parametro para contar 
        //o número de alunos cadastrados na Propriedade Alunos
        public int ObterQuantidadeAlunosMatriculados(){
            int quntidade =  Alunos.Count;

            return quntidade;
        }

        //Metodo com retorno bool para remover um aluno da propriedade Alunos  
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        //Metodo vazio, que não recebe parametros, 
        //apresenta no console a propriedade "NomeCompleto" dos 
        //objetos da Classe Pessoa, presentes na propriedade Alunos.  
        public void ListarAlunos(){
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}