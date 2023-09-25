﻿//Classe pai que sera herdada pelo filho - SuperClasse
class animal
{
    public string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

//Classe filha que herdará da classe Animal
//Receberá todos os atributos e métodos da SuperClasse
class cachorro : animal
{
public void Latir(){
    Console.WriteLine($"O cachorro {cor} esta latindo");
}
}

class gato : animal
{
   public override void EmitirSom()
    {
        Console.WriteLine("O gato esta miando");
    }
}

class Program
{
    public static void Main()
    {
        animal animalGenerico = new animal();
        animalGenerico.EmitirSom();

        cachorro meuCachorro = new cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        gato meuGato = new gato();
        meuGato.EmitirSom();

    }
}