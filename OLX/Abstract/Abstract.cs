using OLX.Models;

namespace OLX.Abstract
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
