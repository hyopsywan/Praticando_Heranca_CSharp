namespace Heranca
{
    public class Motocicleta : Veiculo
    {
        public double QuantidadeCilindradas;

          public Motocicleta(string marca, string modelo, double quantidadecilindradas): base(marca, modelo)
        {
            QuantidadeCilindradas = quantidadecilindradas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n----- Motocicletas -----\n");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"A motocicleta {Modelo} possui {QuantidadeCilindradas}cm³ cilindradas.");
        } 
    }
}