using PersonalApp.Domains.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Abstract
{
    public interface IRepository<T> where T : class,IEntity, new()
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> entities);
    }
}
