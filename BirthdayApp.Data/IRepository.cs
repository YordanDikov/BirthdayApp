using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Data
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> All();

        void Add(T item);

        void Delete(int itemId);

        T GetById(int itemId);
    }
}
