//exercicio 001 calculando a media de 3 notas de um aluno

//receber o nome do aluno e armazenar em uma variavel do tipo string 

//receber a nota 1, converter e armazenar em uma variavel int

//receber a nota 2, converter e armazenar em uma variavel int

//receber a nota 3, converter e armazenar em uma variavel int

//declarar uma variavel do tipo int, para receber a media das notas 
//(nota 1 + nota 2 + nota 3)/ 3

//exibir uma mensagem se o aluno estiver aprovado considerando a nota acima de 7

Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine("Digite a nota 1");
int nota1 = int.Parse (Console.ReadLine());
Console.WriteLine("Digite a nota 2");
int nota2 = int.Parse (Console.ReadLine());
Console.WriteLine("Digite a nota 3");
int nota3 = int.Parse (Console.ReadLine());

int media = (nota1 + nota2 + nota3) / 3 ;

string resultado = (media < 7) ? $"O aluno {nome} tirou {media} e foi reprovado" : $"O aluno {nome} tirou {media} e foi aprovado";
Console.WriteLine(resultado);

