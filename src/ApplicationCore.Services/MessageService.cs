namespace ApplicationCore.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using ApplicationCore.Domain.Models;
    using ApplicationCore.Domain.Interfaces.Repositories;
    using ApplicationCore.Services.Interfaces;

    public class MessageService : IBaseService, IMessageService
    {
        private readonly IRepository<Message> Repository;

        public MessageService(IRepository<Message> repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("Message repository is required");
            }

            this.Repository = repository;

            this.ValidationResults = new List<ValidationResult>();
        }

        public List<ValidationResult> ValidationResults { get; set; }

        public void Write(Message message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("Message is required");
            }

            if (!this.IsValidModel<Message>(message))
            {
                throw new InvalidOperationException("Message entered is invalid");
            }

            this.Repository.Create(message);
        }
    }
}
