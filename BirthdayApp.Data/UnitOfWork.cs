using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext context;
        private Dictionary<Type, object> repositories = new Dictionary<Type,object>();

        public IRepository<Image> Images
        {
            get 
            {
                return GetRepository<Image>();
            }
        }

        public IRepository<Category> Categories
        {
            get 
            {
                return GetRepository<Category>();
            }
        }

        private IRepository<T> GetRepository<T>() where T:class
        { 
            Type key = typeof(T);
            if (!repositories.ContainsKey(key))
            {
                repositories.Add(key, new Repository<T>(context));
            }
            return (IRepository<T>)repositories[key];
        }

        public UnitOfWork() : this(new ApplicationDbContext()) { }

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
