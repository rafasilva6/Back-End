//somente declarando uma variavel do tipo inteira e sem valor
//int num1;

//declarando uma variavel do tipo inteiro e atribuindo o valor 5
//int num2 = 5;

//declarando variavel string
//string nomeAluno = "Rafa";

//variavel do tipo logico (true ou false)
//bool resultado = true;

//variavel do tipo double e valor com varias casas decimais
//double coordenada = 1.359734;

//variavel do tipo decimal - utilizada para valores
//decimal valor = 1.80M;

int idade = 17;
string meuNome = "Rafaela";
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");
Console.WriteLine("");
Console.WriteLine($"Em qual cidade você nasceu?");
//ReadLine serve apenas para que eu receba uma informação do usuario
//e armazeno em um variavel
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomeCidade}");