//O namespace é um nome em que usaremos para fazer referencia quando usarmos 
//em outras classes
namespace Sesi.Model{

    //Declarando nossa classe Aluno
    public class Aluno{

       //Declarando nosso atributo (propriedade) da classe
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }
        private int nrFaltas { get; set; }

        //criando um método
        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma}!");
        }

        public void AdicionarFaltas(int nr){
            nrFaltas = nrFaltas + nr;
        }

        public void ResumirFaltas(){
             Console.WriteLine($"{nome} voce tem {nrFaltas} faltas");
        }

        public void JustificarFaltas( int nr){
            nrFaltas = nrFaltas -  nr;
        }

    }
}