namespace Heranca
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas;

          public Carro (string marca, string modelo, int quantidadeportas): base(marca, modelo)
        {
             QuantidadePortas = quantidadeportas;
        }

          public override void ExibirInformacoes()
        {
            Console.WriteLine("\n----- Carros -----\n");

            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo do carro: {Modelo}");
            Console.WriteLine($"O Carro {Modelo} possui {QuantidadePortas} portas.");
        } 
    }
}
