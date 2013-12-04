using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BirthdayApp.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext context;
        private IDbSet<T> entries;

        public Repository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
            this.context = context;
            this.entries = this.context.Set<T>();
        }

        public Repository() : this(new ApplicationDbContext()) { }

        public IQueryable<T> All()
        {
            return this.entries.AsQueryable();
        }

        public void Add(T item)
        {
            DbEntityEntry entry = this.context.Entry(item);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.entries.Add(item);
            }
        }

        public void Delete(int itemId)
        {
            DbEntityEntry entry = this.context.Entry(GetById(itemId));

            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
        }

        public T GetById(int itemId)
        {
            T result = entries.Find(itemId);
            return result;
        }
    }
}
