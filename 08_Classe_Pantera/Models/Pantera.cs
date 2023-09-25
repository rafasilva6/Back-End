namespace Panteras.Model
{
    public class Pantera
    {
        public decimal tamanho { get; set; }
        public int peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentacao { get; set; }

        public void Correr()
        {
            Console.WriteLine($"A pantera é da especie {especie} e esta correndo ");
        }
        public void Cacar()
        {
            Console.WriteLine($"A pantera {cor} esta caçando {alimentacao} para comer");
        }

        public void Reproduzir()
        {
            Console.WriteLine($"A pantera reproduz e seus filhotes pode crescer até {tamanho}m e pesar {peso}kg");
        }

    }
}