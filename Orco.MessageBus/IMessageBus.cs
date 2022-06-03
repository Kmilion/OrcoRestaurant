using System;
using System.Threading.Tasks;

namespace Orco.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMessage(BaseMessage message, string topicName);
    }
}
