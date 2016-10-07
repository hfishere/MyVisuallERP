using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Repository.Interfaces
{
    public interface IEntityRepository<T, P>
    {
        IQueryable<T> GetAllData();
        T Search(P id);
        void Insert(T entity);
        void Delete(P id);
        void Update(T entity);
    }
}
