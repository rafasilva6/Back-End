Console.WriteLine("Digite o valor de x:");
int x = int.Parse (Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse (Console.ReadLine());

//Exemplos de operadores aritmeticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restodiv2 = x % 2; //calculando o resto da divisão de x / 2
int restodi2 = y % 2;//calculando o resto da divisão de y / 2

//Console para exibir na tela as variaveis em cada linha
//Soma: 15
Console.WriteLine($"Soma:{soma}");
Console.WriteLine($"Subtração:{subtracao}");
Console.WriteLine($"Multiplicação:{multiplicacao}");
Console.WriteLine($"Divisão:{divisao}");
Console.WriteLine($"Resto:{resto}");

if(restodiv2 == 0){
    Console.WriteLine($"O numero {x} é par");
}else {
    Console.WriteLine($"O numero {x} é impar");
}

if(restodi2 == 0){
    Console.WriteLine($"O numero {y} é par");
}else {
    Console.WriteLine($"O numero {y} é impar");
}

//Operador ternario
//condição ? se verdade e : senão
string resultado = (restodi2 == 0) ? $"O numero {y} é par" : $"O numero {y} é impar";
Console.WriteLine(resultado);

int diaSemana = 7;
//Aprendendo o switch case
switch(diaSemana)
{
    case 1:
    Console.WriteLine("hoje é domingo");
    break;
    case 2:
    Console.WriteLine("hoje é segunda");
    break;
    case 3:
    Console.WriteLine("hoje é terça");
    break;
    case 4:
    Console.WriteLine("hoje é quarta");
    break;
    case 5:
    Console.WriteLine("hoje é quinta");
    break;
    case 6:
    Console.WriteLine("hoje é sexta");
    break;
    case 7:
    Console.WriteLine("hoje é sabado");
    break;
    default:
    Console.WriteLine("dia invalido");
}

















