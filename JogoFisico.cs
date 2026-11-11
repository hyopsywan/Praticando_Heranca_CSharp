namespace AtividadeHerancaPOO
{
    public class JogoFisico : Jogo
    {
          public JogoFisico(string nome, string plataforma) : base (nome, plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

         public override void JogosInformacoes()
        {
            Console.WriteLine($"\n---- Jogos Físicos ----\n");

            Console.WriteLine($"Jogo: {Nome}.");
            Console.WriteLine($"Plataforma: {Plataforma}.");
        }
    }

}