namespace AtividadeHerancaPOO
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadedePaginas;

        
          public Ebook(string nome, decimal preco, int quantidadedepaginas): base(nome, preco)
        {
            QuantidadedePaginas = quantidadedepaginas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"\n---- E-Books -----\n");

            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"O livro {Nome} possui {QuantidadedePaginas} páginas.");
        } 

    }
}