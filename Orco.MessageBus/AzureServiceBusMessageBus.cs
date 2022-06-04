using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orco.MessageBus
{
    public class AzureServiceBusMessageBus : IMessageBus
    {
        private string connectionString = "Endpoint=sb://orcorestaurant.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=WGd0VMcncUTXD4cN9H+fGUdyhKJWDrT3YtQXiLYHB44=";
        public async Task PublishMessage(BaseMessage message, string topicName)
        {
            await using var client = new ServiceBusClient(connectionString);

            ServiceBusSender sender = client.CreateSender(topicName);

            var jsonMessage = JsonConvert.SerializeObject(message);

            ServiceBusMessage finalMessage = new(Encoding.UTF8.GetBytes(jsonMessage))
            {
                CorrelationId = Guid.NewGuid().ToString(),
            };

            await sender.SendMessageAsync(finalMessage);

            await client.DisposeAsync();
        }
    }
}
