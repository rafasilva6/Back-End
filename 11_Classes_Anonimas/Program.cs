public class Program
{
    public static void Main()
    {
        //Criando uma classe anonima (classe sem definiçao inicial)
        var pessoa1 = new
        {
            nome = "Joao",
            idade = 17
        };
        var pessoa2 = new
        {
            nome = "maria",
            email = "maria@aluno.senai.br"
        };
        Console.WriteLine($"A pessoa1 é o {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa2 é a {pessoa2.nome} e tem o email {pessoa2.email}");

        //pessoa1.nome = Douglas

        //Criar 2 objetos de classe anonima de carro
        var carro1 = new
        {
            marca = "Honda",
            modelo = "HRV",
            ano = 2018
        };
        Console.WriteLine($"O carro1 é {carro1.modelo} que é da marca {carro1.marca} e do ano {carro1.ano} ");
        var carro2 = new
        {
            marca = "Toyota",
            modelo = "Creta",
            ano = 2021
        };
        Console.WriteLine($"O carro2 é {carro2.modelo} que é da marca {carro2.marca} e do ano {carro2.ano} ");
    }
}