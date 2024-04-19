using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// PRIMEIRO TESTE DE EXECUÇÃO >> Retornado erro: 1 / 4 Testes de tiveram sucesso.

// int saldoTotal = int.Parse(Console.ReadLine());
// int valorSaque = int.Parse(Console.ReadLine());

//     //TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.
// if (saldoTotal >= valorSaque) {
//     saldoTotal -= valorSaque;
//     Console.WriteLine ($"Saque realizado com sucesso. Novo saldo: {saldoTotal}");
// }
// else 
// {
//     Console.WriteLine ("Saldo insuficiente. Saque nao realizado!");
// }




// SEGUNDO TESTE DE EXECUÇÃO >> Retornado erro: 1 / 4 Testes tiveram sucesso.

// int saldoTotal = int.Parse(Console.ReadLine());
// int valorSaque = int.Parse(Console.ReadLine());

        //TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.
// if (saldoTotal >= 1000 && valorSaque <= 200) {
//     saldoTotal -= valorSaque;
//     Console.WriteLine ($"Saque realizado com sucesso! Novo saldo: {saldoTotal}");
// }
// else if (saldoTotal >= 300 && valorSaque <= 200) {
//         saldoTotal -= valorSaque;
//         Console.WriteLine ($"Saque realizado com sucesso! Novo saldo: {saldoTotal}");
// }
// else if (saldoTotal <= 1500 && valorSaque <= 1800) {
//         saldoTotal -= valorSaque;
//         Console.WriteLine ("Saldo insuficiente. Saque nao realizado!");
// }
// else {
//         Console.WriteLine ("Saldo insuficiente. Saque nao realizado!");
// }




// TERCEIRO TESTE DE EXECUÇÃO >> Retornado sucesso: 4 / 4 Testes tiveram sucesso. Clique em "ENTREGAR DESAFIO" para finalizar.

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
