namespace Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using ApplicationCore.Domain.Models;

    public class MessageConsoleRepository : BaseRepository<Message>
    {
        public override IEnumerable<Message> GetAll(IDictionary<string, object> criteria)
        {
            throw new NotImplementedException();
        }

        public override Message Get(long id)
        {
            throw new NotImplementedException();
        }

        public override void Create(Message model)
        {
            Console.WriteLine(model.Value);
        }

        public override void Update(Message model)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Message model)
        {
            throw new NotImplementedException();
        }
    }
}
