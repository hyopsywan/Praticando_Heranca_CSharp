namespace Heranca
{
    public abstract class Notificacao
    {
        public string? Mensagem;

        public Notificacao(string mensagem = "Notificação genérica do sistema")
        {
            Mensagem = mensagem;
        }

        public virtual void Enviar()
        {
            Console.WriteLine($"Teste {Mensagem}");
        }
    }
}