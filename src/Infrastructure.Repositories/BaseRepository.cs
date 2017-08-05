namespace Infrastructure.Repositories
{
    using System.Collections.Generic;
    using ApplicationCore.Domain.Interfaces.Repositories;

    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        public abstract IEnumerable<T> GetAll(IDictionary<string, object> criteria);

        public abstract T Get(long id);

        public abstract void Create(T model);

        public abstract void Update(T model);

        public abstract void Delete(T model);
    }
}
