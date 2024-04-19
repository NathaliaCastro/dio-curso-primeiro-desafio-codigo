using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// PRIMEIRO TESTE DE EXECUÇÃO >> Retornado erro: 0 / 3 Testes tiveram sucesso.

// List<string> itens = new List<string>(3);

// for (int contador = 0; contador < itens; contador++)
// {
// 	Console.WriteLine("{item1[contador]}");
// }

// Console.WriteLine("Lista de itens:");
// foreach (string item in itens)
// {
//         Console.WriteLine($"- {item}");
// }




// SEGUNDO TESTE DE EXECUÇÃO >> Retornado sucesso: 3 / 3 Testes tiveram sucesso. Clique em "ENTREGAR DESAFIO" para finalizar.

List<string> itens = new List<string>();
   //Lista para armazenar os itens

Console.WriteLine("Digite 3 itens para o seu personagem: \n");
for (int contador = 0; contador <= 2; contador++)     
   //A lista inicia com índice 0 até 2, pois de zero a dois existem três espaços
{        
      string item = Console.ReadLine();
    //Declarando a variável ITEM como string e armazenando os itens inseridos
      itens.Add(item);
    //Adiciona os 3 itens desejados
}

Console.WriteLine("\nLista de itens:");
    // Exibe a lista de itens
foreach (string item in itens)
    //A variável ITEM do tipo string, guarda em ITENS os objetos adicionados anteriormente
{
      Console.WriteLine($"- {item}");
    //Exibe em tela os itens adicionados em : itens.Add(item)
}
