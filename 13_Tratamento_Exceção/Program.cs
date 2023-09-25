public class Program
{

    public static void Main()
    {
        //O try serve para tratar um erro e não parar a execução do programa
        //se ocorrer qualquer erro dentro do bloco try o sistema interrompido
        //a execução do bloco e vai para o catch
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"vc digitou o nr {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"Resultado {resultado}");
        }

        //Tratando exceção de overflow (estouro de campo)
        catch(OverflowException)
        {
            Console.WriteLine("Este numero inteiro é maior que o suportado");

        }

        //Tratando exceção de erro de formato
        catch (FormatException)
        {
            Console.WriteLine("Erro:Digite um numero inteiro");
        }

        //catch é o tratamento de erro, normalmente colocamos as mensagens de acordo
        //com o tipo do erro, para melhor compreensão do usuario
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");

        }
        //o finally é um bloco executado independentemente se ocorrer erro ou n
        finally
        {
            Console.WriteLine($"Ocorreu um erro:");
        }

    }
}