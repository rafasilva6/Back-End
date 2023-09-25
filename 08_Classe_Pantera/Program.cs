using Panteras.Model;

class Program
{
    public static void Main(){
        var pantera1 = new Pantera();
        pantera1.tamanho = 2;
        pantera1.peso = 140;
        pantera1.cor = "branca";
        pantera1.especie = "panthera onca";
        pantera1.alimentacao = "veados, jacarés, antílopes, javalis, gnus, tartarugas e até peixes";

        pantera1.Correr();
        pantera1.Cacar();
        pantera1.Reproduzir();
        
    }
    
}
