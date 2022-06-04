using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Orco.Services.OrderAPI.Messages;
using Orco.Services.OrderAPI.Models;
using Orco.Services.OrderAPI.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Orco.Services.OrderAPI.Messaging
{
    public class AzureServiceBusConsumer : IAzureServiceBusConsumer
    {
        private readonly OrderRepository _orderRepository;
        private readonly string serviceBusConnectionString;
        private readonly string subscriptionCheckout;
        private readonly string checkoutMessageTopic;

        private ServiceBusProcessor checkoutProcessor;

        private readonly IConfiguration _configuration;

        public AzureServiceBusConsumer(OrderRepository orderRepository, IConfiguration configuration)
        {
            _orderRepository = orderRepository;
            _configuration = configuration;

            serviceBusConnectionString = _configuration.GetValue<string>("ServiceBusConnectionString");
            subscriptionCheckout = _configuration.GetValue<string>("SubscriptionCheckout");
            checkoutMessageTopic = _configuration.GetValue<string>("CheckoutMessageTopic");

            var client = new ServiceBusClient(serviceBusConnectionString);

            checkoutProcessor = client.CreateProcessor(checkoutMessageTopic, subscriptionCheckout);
        }

        public async Task Start()
        {
            checkoutProcessor.ProcessMessageAsync += OnCheckoutMessageReceived;
            checkoutProcessor.ProcessErrorAsync += ErrorHandler;
            await checkoutProcessor.StartProcessingAsync();
        }

        public async Task Stop()
        {
            await checkoutProcessor.StopProcessingAsync();
            await checkoutProcessor.DisposeAsync();
        }

        Task ErrorHandler(ProcessErrorEventArgs args)
        {
            Console.WriteLine(args.Exception.ToString());
            return Task.CompletedTask;
        }

        private async Task OnCheckoutMessageReceived(ProcessMessageEventArgs args)
        {
            var message = args.Message;
            var body = Encoding.UTF8.GetString(message.Body);

            CheckoutHeaderDTO checkoutHeaderDTO = JsonConvert.DeserializeObject<CheckoutHeaderDTO>(body);

            OrderHeader orderHeader = new()
            {
                UserId = checkoutHeaderDTO.UserId,
                FirstName = checkoutHeaderDTO.FirstName,
                LastName = checkoutHeaderDTO.LastName,
                OrderDetails = new List<OrderDetails>(),
                CardNumber = checkoutHeaderDTO.CardNumber,
                CouponCode = checkoutHeaderDTO.CouponCode,
                CVV = checkoutHeaderDTO.CVV,
                DiscountTotal = checkoutHeaderDTO.DiscountTotal,
                Email = checkoutHeaderDTO.Email,
                ExpiryMonthYear = checkoutHeaderDTO.ExpiryMonthYear,
                OrderTime = DateTime.Now,
                OrderTotal = checkoutHeaderDTO.OrderTotal,
                PaymentStatus = false,
                Phone = checkoutHeaderDTO.Phone,
                PickupDateTime = checkoutHeaderDTO.PickupDateTime
            };

            foreach (var detailList in checkoutHeaderDTO.CartDetails)
            {
                OrderDetails orderDetails = new()
                {
                    ProductId = detailList.ProductId,
                    ProductName = detailList.Product.Name,
                    Price = detailList.Product.Price,
                    Count = detailList.Count
                };
                orderHeader.CartTotalItems += detailList.Count;
                orderHeader.OrderDetails.Add(orderDetails);
            }
            await _orderRepository.AddOrder(orderHeader);
        }
    }
}
