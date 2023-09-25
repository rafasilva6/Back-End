namespace Models
{
    public class Pessoa
{
    //Atributos da nossa classe Pessoa
    private string nome { get; set; }
    private int idade { get; set; }
    private string email { get; set; }
    private int anoNascimento { get; set; }

    //Metodo construtor da classe Pessoa
    public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa){
        this.nome = nomePessoa;
        this.idade = idadePessoa;
        this.email = emailPessoa;
        //this.anoNascimento = 2023 - idade;
        this.anoNascimento = DateTime.Now.Year - idadePessoa;
    }

    //Metodo da classe Pessoa
    public void Cantar()
    {
        Console.WriteLine($"{nome} está cantando");
    }
    public void informacoes(){
        Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos pois nasci em {anoNascimento} e meu email é {email}");
    }
}
}