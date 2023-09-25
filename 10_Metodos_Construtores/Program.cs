using Models;
public class Program
{
    public static void Main()
    {
        //Criando objeto da classe Pessoa
        //instanciando sem um método construtor
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Rafaela";
        pessoa1.idade = 17;
        pessoa1.Cantar();

        //Alternativa para criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa
        {
            nome = "Ricardo",
            idade = 28
        };
        pessoa2.Cantar();
        */
        Pessoa pessoa1 = new Pessoa("Rafaela", 17, "srafah1508@gmail.com");
        pessoa1.Cantar();
        pessoa1.informacoes();

        Pessoa pessoa2 = new Pessoa("Deivid", 19, "deivid.santana@gmail.com");
        pessoa2.Cantar();
        pessoa2.informacoes();

        Pessoa pessoa3 = new Pessoa("Lara", 31, "souza.lara@gmail.com");
        pessoa3.Cantar();
        pessoa3.informacoes();
    }
}