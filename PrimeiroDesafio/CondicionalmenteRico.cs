using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

int saldoTotal = int.Parse(Console.ReadLine()); 
   //Declarando inteiro e convertando em String

int valorSaque = int.Parse(Console.ReadLine()); 
   //Declarando inteiro e convertando em String

int saldoDisponivel = saldoTotal - valorSaque;
   //Declarando a variavel SALDO_DISPONIVEL para obter o saldo após efetuar o saque

if (saldoTotal >= valorSaque) {
   //Para o saldo da conta MAIOR ou IGUAL o valor do saque
Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldoDisponivel}");
}
else {
   //Para o saldo da conta MENOR que o valor do saque
Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
}
