using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IEmailSender
    {
        void SendEmail(string message, string email);
    }

    public class EmailSender : IEmailSender
    {
        public void SendEmail()
        {

        }

        public void SendEmail(string message, string email)
        {

        }
    }

    public class EmailSenderStub : IEmailSender
    {
        public void SendEmail()
        {

        }

        public void SendEmail(string message, string email)
        {

        }
    }

    public class EmailSenderFake : IEmailSender
    {
        public void SendEmail()
        {

        }

        public void SendEmail(string message, string email)
        {
            File.WriteAllText("D:\\emails.txt", $"From:{email}\nMessage:{message}");
        }
    }

    public class Notifier
    {
        private readonly IEmailSender sender;
        public Notifier(IEmailSender sender)
        {
            this.sender = sender;
        }

        public void SendMessage(string message)
        {
            sender.SendEmail(message, "param@example.com");
        }
    }


    public class Warehouse
    {

        Notifier notifier;

        public Warehouse(Notifier notifier)
        {
            this.notifier = notifier;
        }

        public Warehouse(params string[] items)
        {
            if (items.Length < 1)
            {
                throw new InvalidOperationException();
            }

            items.ToList().ForEach(item => this.items.Add(item));
        }
        private HashSet<string> items = new HashSet<string>();

        public void Add(string name)
        {
            if (name.Contains("Food"))
                throw new InvalidOperationException($"cannot save item with name {name}");
            items.Add(name);


        }

        public uint Count()
        {
            return (uint)items.Count;
        }

        public void Remove(string itemName)
        {
            if (!items.Contains(itemName))
            {
                throw new InvalidOperationException();
            }

            items.Remove(itemName);
        }
    }
}
