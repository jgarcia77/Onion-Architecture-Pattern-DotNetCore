namespace Clients.ConsoleApplication
{
    using System;
    using ApplicationCore.Domain.Models;
    using ApplicationCore.Services.Interfaces;

    public class Application : IApplication
    {
        private readonly IMessageService MessageService;
        public Application(IMessageService messageService)
        {
            this.MessageService = messageService;
        }

        public void Run()
        {
            Console.WriteLine("Hi there!");
            Console.WriteLine("");
            Console.Write("Please enter a message (i.e. Hello World): ");

            var value = Console.ReadLine();

            try
            {
                Console.WriteLine("");
                Console.WriteLine("");

                this.MessageService.Write(new Message { Value = value });
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
