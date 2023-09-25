namespace ContaBancaria
{

    public class ContaCorrente
    {
        private string titular { get; set; }
        private double saldo { get; set; }

        public ContaCorrente(string nomePessoa)
        {
            this.titular = nomePessoa;
            this.saldo = 0;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Valor disponivel: {saldo}");
        }
        public void Depositar()
        {
            Console.WriteLine($"Digite o valor a depositar:");
            double nrDepositar = double.Parse(Console.ReadLine());
            
            if (nrDepositar > 0)
            {
                saldo = saldo + nrDepositar;
                Console.WriteLine($"Você depositou {nrDepositar}");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente ou valor de saque invalido");
            }
        }

        public void Sacar()
        {
            Console.WriteLine($"Digite o valor a sacar:");
            double nrSacar = double.Parse(Console.ReadLine());
            
            if (nrSacar <= saldo)
            {
                saldo = saldo - nrSacar;
                Console.WriteLine($"Você sacou {nrSacar}");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente ou valor de saque invalido");
            }

        }
    }
}

