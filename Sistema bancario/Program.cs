using ContaBancaria;
class Program
{
    public static void Main()
    {

        
        Console.WriteLine($"BEM VINDO AO BANK !");
        Console.WriteLine("----------------------");
        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine("Digite seu nome: ");
        ContaCorrente conta1 = new ContaCorrente(Console.ReadLine());
        string opcao = "";
        do
        {
            Console.WriteLine("############ Menu ############");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {

                case "1":
                    conta1.ConsultarSaldo();
                    break;
                case "2":
                    conta1.Depositar();
                    break;
                case "3":
                    conta1.Sacar();
                    break;
                case "4":
                    Console.WriteLine("Obrigada, volte sempre!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        } while (opcao != "0");
    }
}
