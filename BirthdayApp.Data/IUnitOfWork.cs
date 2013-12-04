using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Image> Images { get; }

        IRepository<Category> Categories { get; }

        int SaveChanges();
    }
}
