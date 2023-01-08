using System.Threading.Tasks;
using Core.Domain.Model.MessageBroker;

namespace Core.Application.Contracts.Services
{
    public interface ISendEmailBusPublisher
    {
        public Task SendEmailAsync(EmailMessageModel message);
    }
}