namespace AtividadeHerancaPOO
{
    public class JogoDigital : Jogo
    {
        public JogoDigital(string nome, string plataforma) : base (nome, plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        public override void JogosInformacoes()
        {
            Console.WriteLine($"\n---- Jogos Digitais ----\n");

            Console.WriteLine($"Jogo: {Nome}.");
            Console.WriteLine($"Plataforma: {Plataforma}.");
        }
    }
}