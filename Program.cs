﻿// See https://aka.ms/new-console-template for more information
using Aula_CSharp.Models;




/***************** Conceitos POO ********************/

ContaCorrente minhaConta =new ContaCorrente(123456, 129.90M);
Console.WriteLine("Numero da conta corrente é "+ minhaConta.NumeroConta);
minhaConta.ExibirSaldo();
Console.WriteLine("Sacar R$59,70:");
minhaConta.Sacar(59.70M);
minhaConta.ExibirSaldo();
Console.WriteLine("Sacar R$109,70:");
minhaConta.Sacar(109.70M);
minhaConta.ExibirSaldo();



/***************** Exceções e Coleções ********************/

// leitura de arquivo txt 
// try{
//     string[] lines = File.ReadAllLines("Arquivos/ArquivoDeTexto.txt");

//     foreach (string line in lines){
//         Console.WriteLine(line);
//     }
// }catch(Exception ex){
//     Console.WriteLine(ex.Message);
// }


/******* CLASSES, PROPRIEDADES, METODOS E CONSTRUTORES *****/

// //Construtor 1
// Pessoa pessoa = new()
// {
//     Nome = "João",
//     Sobrenome = "Carlos",
//     Idade = 25,
// };

// //Construtor 2
// Pessoa pessoa2 = new Pessoa("Leonardo","Buta")
// {
//  Idade = 22,
// };

// //Construtor 3
// Pessoa pessoa3 = new Pessoa("Maria", "Diva Macedo", 65);

// //usando construtores e expandindo a noção de metodos e propriedades
// Curso dio = new Curso(){
//     Nome = "FullStack",
// };
// //exibir a propriedade Nome do objeto da classe Curso
// Console.WriteLine($"\n\nNome do curso é {dio.Nome}.");

// //Utilizando o metodo AdicionarAluno 
// dio.AdicionarAluno(pessoa);
// dio.AdicionarAluno(pessoa2);
// dio.AdicionarAluno(pessoa3);

// // Mostrar o número de alunos matriculados
// Console.WriteLine($"\n\nO número de alunos matriculados é: {dio.ObterQuantidadeAlunosMatriculados()}");

// // Listar os alunos matriculados
// Console.WriteLine("\n\nOs alunos matriculados são:");
// dio.ListarAlunos();

// // remover um dos alunos
// if(dio.RemoverAluno(pessoa2)){
//     Console.WriteLine($"\n\nX Alunx {pessoa2.NomeCompleto} foi removidx");
//     Console.WriteLine("Os alunos matriculados, agora, são:");
//     dio.ListarAlunos();
// }





