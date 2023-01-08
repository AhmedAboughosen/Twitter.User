﻿using System.Text;
using System.Threading.Tasks;
using Core.Application.Contracts.Services;
using Core.Domain.Model.MessageBroker;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace Infrastructure.MessageBus.Publisher
{
    public class SendEmailBusPublisher : ISendEmailBusPublisher
    {
        private readonly ConnectionFactory _connectionFactory;
        private readonly string _queueName;

        public SendEmailBusPublisher(IConfiguration configuration)
        {
            _connectionFactory = new ConnectionFactory() {HostName = configuration["MessageBroker:Localhost"]};
            _queueName = configuration["MessageBroker:QueueName"];
        }

        public Task SendEmailAsync(EmailMessageModel message)
        {
            using var connection = _connectionFactory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(
                queue: _queueName,
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);


            var json = JsonConvert.SerializeObject(message);

            var body = Encoding.UTF8.GetBytes(json);

            channel.BasicPublish("", _queueName, null, body);

            return Task.CompletedTask;
        }
    }
}