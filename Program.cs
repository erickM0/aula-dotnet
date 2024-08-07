// See https://aka.ms/new-console-template for more information
using Aula_CSharp.Models;


Pessoa pessoa = new()
{
    Nome = "João",
    Sobrenome = "Carlos",
    Idade = 25,
};

Pessoa pessoa2 = new()
{
    Nome = "Leonardo",
    Sobrenome = "Buta",
    Idade = 29,
};

Pessoa pessoa3 = new()
{
    Nome = "Maria",
    Sobrenome = "Diva Macedo",
    Idade = 60,
};


Curso dio = new Curso(){
    Nome = "FullStack",
};

dio.Alunos = new List<Pessoa>();
Console.WriteLine(dio.Nome);

dio.AdicionarAluno(pessoa);
dio.AdicionarAluno(pessoa2);
dio.AdicionarAluno(pessoa3);

Console.WriteLine(dio.ObterQuantidadeAlunosMatriculados());

dio.ListarAlunos();

if(dio.RemoverAluno(pessoa2)){
    dio.ListarAlunos();
}





