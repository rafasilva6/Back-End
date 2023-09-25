using System.IO;

public class Program
{
    public static string CaminhoArquivo = "Arquivo/arquivo2.txt";
    public static void Main()
    {
        //Chamar o metodo ChamarArquivo
        ChamarArquivo();
        //Chamar o metodo LerArquivo
        LerArquivo();
    }

    public static void LerArquivo()
    {
        try{
            
            //verificar se o arquivo existe
            if (File.Exists (CaminhoArquivo) == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando
                //a verificação no if é falsa, ou seja o arquivo não existe
                File.Create (CaminhoArquivo);
            }

        //Instanciando um objeto da classe StreamReader para ler o arquivo
        using (StreamReader arquivo = new StreamReader (CaminhoArquivo))
        {
            string linha;
            //fazendo o while para ler linha por linha que contem no arquivo
            while ((linha = arquivo.ReadLine()) != null)
            {
                //Escrevendo no console o conteudo da linha
                Console.WriteLine(linha);
            }
        }
        }
        catch (Exception erro){
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
        }

    }
    
    public static void ChamarArquivo()
    {
        try
        {
            //Instanciando um objeto da classe StreamWriter para gravar em arquivo
            using (StreamWriter arquivo = new StreamWriter(CaminhoArquivo, true))
            {
                Console.WriteLine("Digite um texto para salvar no arquivo");
                string texto = Console.ReadLine();
                arquivo.WriteLine(texto);
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}