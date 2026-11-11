namespace Heranca
{
    public abstract class Veiculo
    {
        public string? Marca { get; set;}
        public string? Modelo { get; set;}

        public Veiculo()
        {
            
        }

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        } 
    }

}
