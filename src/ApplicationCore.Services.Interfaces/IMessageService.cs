namespace ApplicationCore.Services.Interfaces
{
    using ApplicationCore.Domain.Models;

    public interface IMessageService
    {
        void Write(Message message);
    }
}
