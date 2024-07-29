using System;
using System.Collections.Generic;

namespace Interface
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending email with message: {message}");
        }
    }

    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS with message: {message}");
        }
    }

    public class PushNotificationSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending push notification with message: {message}");
        }
    }

    public class MessageService
    {
        private readonly IMessageSender _messageSender;

        public MessageService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Send(string message)
        {
            _messageSender.SendMessage(message);
        }
    }

    public class InterfaceExample
    {
        static void Main(string[] args)
        {
            List<IMessageSender> messageSenders = new List<IMessageSender>
            {
                new EmailSender(),
                new SmsSender(),
                new PushNotificationSender()
            };

            foreach (var sender in messageSenders)
            {
                MessageService messageService = new MessageService(sender);
                messageService.Send("Hello World");
            }
        }
    }
}