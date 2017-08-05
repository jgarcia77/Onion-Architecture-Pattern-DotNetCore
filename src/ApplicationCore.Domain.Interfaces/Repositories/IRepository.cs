namespace ApplicationCore.Domain.Interfaces.Repositories
{
    using System.Collections.Generic;

    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll(IDictionary<string, object> criteria);
        T Get(long id);
        void Create(T model);
        void Update(T model);
        void Delete(T model);
    }
}
