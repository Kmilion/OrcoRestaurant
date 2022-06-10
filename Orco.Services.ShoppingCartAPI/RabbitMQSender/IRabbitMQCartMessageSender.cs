using Orco.MessageBus;

namespace Orco.Services.ShoppingCartAPI.RabbitMQSender
{
    public interface IRabbitMQCartMessageSender
    {
        void SendMessage(BaseMessage baseMessage, string queueName);
    }
}
