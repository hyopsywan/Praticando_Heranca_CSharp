
namespace AtividadeHerancaPOO
{
    public class CursosOnline : ProdutoDigital
    {
        public int CargaHoraria;


        public CursosOnline(string nome, decimal preco, int cargahoraria) : base(nome, preco)
        {
            CargaHoraria = cargahoraria;
        }

         public override void ExibirInformacoes()
        {
            Console.WriteLine($"\n---- Cursos Online -----\n");

            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"O curso {Nome} possui {CargaHoraria}h de duração.");
        } 
    }
}