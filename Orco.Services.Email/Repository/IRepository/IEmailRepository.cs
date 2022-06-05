using Orco.Services.Email.Messages;
using Orco.Services.Email.Models;
using System.Threading.Tasks;

namespace Orco.Services.Email.Repository.IRepository
{
    public interface IEmailRepository
    {
        Task SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
