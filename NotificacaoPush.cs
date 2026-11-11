using Heranca;

namespace Praticando_Heranca_CSharp
{
    public class NotificacaoPush : Notificacao
    {

        public NotificacaoPush(string mensagem) : base(mensagem)
        {
            
        }

        public override void Enviar()
        {
            Console.WriteLine($"\n---- Notificação Push ----\n");
            Console.WriteLine($"push: {Mensagem} ");
        }
    }
}