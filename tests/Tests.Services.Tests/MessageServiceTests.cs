namespace Tests.Services.Tests
{
    using System;
    using Xunit;
    using Moq;
    using ApplicationCore.Domain.Models;
    using ApplicationCore.Services;
    using ApplicationCore.Domain.Interfaces.Repositories;

    public class MessageServiceTests
    {
        [Fact]
        public void Constructor_ArgumentNullException()
        { 
            Assert.Throws<ArgumentNullException>(() => new MessageService(null));
        }

        [Fact]
        public void Write_ArgumentNullException()
        {
            var mockRepository = new Mock<IRepository<Message>>();
            var service = new MessageService(mockRepository.Object);

            Assert.Throws<ArgumentNullException>(() => service.Write(null));
        }

        [Fact]
        public void Write_InvalidOperationException()
        {
            var mockRepository = new Mock<IRepository<Message>>();
            var service = new MessageService(mockRepository.Object);
            var message = new Message();

            Assert.Throws<InvalidOperationException>(() => service.Write(message));
        }

        [Fact]
        public void Write_Successful()
        {
            var mockRepository = new Mock<IRepository<Message>>();
            var service = new MessageService(mockRepository.Object);
            var message = new Message { Value = "Hello World" };

            service.Write(message);

            mockRepository.Verify(m => m.Create(message), Times.Once);
        }
    }
}
