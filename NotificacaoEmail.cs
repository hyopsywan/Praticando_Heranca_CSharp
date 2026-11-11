using Heranca;

namespace Praticando_Heranca_CSharp
{
    public class NotificacaoEmail : Notificacao
    {

         public NotificacaoEmail(string mensagem) : base(mensagem)
        {
            
        }

        public override void Enviar()
        {
            Console.WriteLine($"\n---- Notificação E-mail ----\n");
            Console.WriteLine($"email: {Mensagem}");
        }
    }
}