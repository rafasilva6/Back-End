using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
        //Criando uma lista de inteiros
        List<int> listaNumeros = new List<int> { };

        //Adicionando elementos à lista
        listaNumeros.Add(10);  // posiçao [0]
        listaNumeros.Add(20); // posição [1]
        listaNumeros.Add(45); //posição [2]


        //Acessando os dados da lista pelo indice
        Console.WriteLine(listaNumeros[0]);
        Console.WriteLine(listaNumeros[1]);

        //Contagem de elementos
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55); //posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        Console.WriteLine("/////////////////////////////////////////////////////////////////////////////");

        List<string> listaNomes = new List<string> { };
        listaNomes.Add("Rafaela");
        listaNomes.Add("Deivid");
        listaNomes.Add("Clara");
        listaNomes.Add("Giovana");
        listaNomes.Add("Julia");

        Console.WriteLine(listaNomes[0]);
        Console.WriteLine(listaNomes[1]);

        Console.WriteLine($"Neste momento temos {listaNomes.Count} elementos");
        Console.WriteLine("/////////////////////////////////////////////////////////////////////////////");

        //Criando uma lista de numeros já atribuindo valores
        List<int> numeros = new List<int> { 1, 2, 5, 6, 8, 9 };
        Console.WriteLine($"Quantidade de elementos na lista números: {numeros.Count}");
        numeros.Remove(2); //Remover o elemento 2 - remover pelo conteudo
        numeros.RemoveAt(1); //Remover o elemento do indice 1 - remover pela posição
        numeros.RemoveRange(2, 2); //Remover 2 elementos a partir do indice 2

        //Substituindo informação do item da lista
        numeros[0] = 100;

        //Iterando sobre todos os itens da lista
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        //Iterando sobre todos os itens da lista nome
        foreach (string nome in listaNomes)
        {
            Console.WriteLine(nome);
        }

        Console.WriteLine("/////////////////////////////////////////////////////////////////////////////");

        //criando uma lista com objetos da classe aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //adicionando um novo aluno a minha lista
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));

        //Exibindo lista de alunos
        Console.WriteLine("Lista alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos");
        }

        //Criando uma nova lista, ordenando por nome
        //LINQ utilizando Sintaxe de consulta
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno.nome);
        }

        //LINQ utilizando Sintaxe de metodo
        var consulta = listaAlunos
                           .Where(aluno => aluno.idade == 17)
                           .OrderBy(aluno => aluno.nome);
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }

    }
}