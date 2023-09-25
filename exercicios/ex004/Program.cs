class Sesi{
public static void Main(){

    Console.WriteLine("Digite um n°");
    int numero = int.Parse(Console.ReadLine());

    double resultado = dobro(numero);
    Console.WriteLine($"O dobro é {resultado}");

    double resultado2 = metade(numero);
    Console.WriteLine ($" A metade é {resultado2}");

    tabuada(numero);
    ResumoSalarios();
}


  public static double dobro(int num){
        double resultado = (num)*2;
        return resultado;
    }

    public static double metade (int num){
        int metade1 = (num)/2;
        return metade1;
    }

public static void tabuada(int num){
    int contador = 1;

    while (contador <=10){
        Console.WriteLine($"{contador}° execuçao: {num} X {contador} = {num * contador}");
        contador++;
    }

}  

public static void ResumoSalarios(){
    int SomaSalario = 0;
    int menorSalario = 100000;
    int maiorSalario = 0;
    int salarioEmpregado = 0;

    do{
        Console.WriteLine("Digite o salario do empregado:");
        salarioEmpregado = int.Parse(Console.ReadLine());

        SomaSalario = SomaSalario + salarioEmpregado;
        //somaSalarios += salarioEmpregado;
        if (salarioEmpregado > maiorSalario){
            maiorSalario = salarioEmpregado;
        }
        if (salarioEmpregado < menorSalario && salarioEmpregado > 0){
            menorSalario = salarioEmpregado;
        }

    } while (salarioEmpregado > 0);
        Console.WriteLine($"A soma dos salarios é {SomaSalario}, o maior salario é {maiorSalario} e o menor {menorSalario}");




}


}