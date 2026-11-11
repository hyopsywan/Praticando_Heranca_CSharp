using Heranca;

namespace Praticando_Heranca_CSharp
{
    public class NotificacaoSMS : Notificacao
    {

         public NotificacaoSMS(string mensagem) : base(mensagem)
        {
            
        }

        public override void Enviar()
        {
            Console.WriteLine($"\n---- Notificação SMS ----\n");
            Console.WriteLine($"sms: {Mensagem}");
        }
    }
}