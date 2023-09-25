//Sempre que formos utilizar bibliotecas ou classes ja criadas
//importamos ela com o using
//Linkar usando using e o nome da classe
using Sesi.Model;

class Program{
    public static void Main(){
        //criando variavel aluno1 e instaciando da classe Aluno
        //ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Rafaela";
        aluno1.idade = 17;
        aluno1.turma = "2º EM";
        //Chamando o metodo da classe aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
        aluno1.ResumirFaltas();


        //Deixando o aluno atribuir o valor
        var aluno2 = new Aluno();
        Console.WriteLine("Digite seu nome");
        aluno2.nome = (Console.ReadLine());
        Console.WriteLine("Digite sua idade");
        aluno2.idade = int.Parse (Console.ReadLine());
        Console.WriteLine("Digite sua turma atual");
        aluno2.turma = (Console.ReadLine());
        //Chamando o metodo da classe aluno
        aluno2.Apresentar();
        aluno2.ResumirFaltas();
        aluno2.AdicionarFaltas(4);
        aluno2.ResumirFaltas();
        aluno2.AdicionarFaltas(7);
        aluno2.ResumirFaltas();
        aluno2.JustificarFaltas(2);
        aluno2.ResumirFaltas();


        var aluno3 = new Aluno();
        aluno3.nome = "Clara";
        aluno3.idade = 13;
        aluno3.turma = "8º EM";
        //Chamando o metodo da classe aluno
        aluno3.Apresentar();
        aluno3.ResumirFaltas();
        aluno3.AdicionarFaltas(3);
        aluno3.ResumirFaltas();
        aluno3.AdicionarFaltas(1);
        aluno3.ResumirFaltas();
        aluno3.JustificarFaltas(2);
        aluno3.ResumirFaltas();

    }
}