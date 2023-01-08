using System;

namespace Core.Domain.Model.MessageBroker
{
    public class EmailMessageModel 
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}