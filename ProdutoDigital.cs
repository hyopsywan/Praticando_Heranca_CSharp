namespace AtividadeHerancaPOO
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }

        public ProdutoDigital()
        {

        }

        public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

         public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
        } 
    }
}