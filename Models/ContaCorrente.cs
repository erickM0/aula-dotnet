using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_CSharp.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;;
        }
        public int NumeroConta{get;set;}
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if(valor <= Saldo){
                Saldo -= valor;

                Console.WriteLine("Valor sacado com sucesso");
            }
            else{
                Console.WriteLine("Saldo Insuficiente!");
            };
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo atual é {Saldo}");
        }
    }
}