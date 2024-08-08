using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_CSharp.Models
{
    public class Curso
    {
        public Curso(){
            Alunos = new List<Pessoa>();
        }
        public string Nome {get; set;}

        public List<Pessoa> Alunos { get; set; }
    
        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados(){
            int quntidade =  Alunos.Count;

            return quntidade;
        }

        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}