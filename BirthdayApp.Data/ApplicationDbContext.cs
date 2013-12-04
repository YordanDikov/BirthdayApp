using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public IDbSet<Image> Images { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public ApplicationDbContext() : base("BirthdayApplicationDbContext")
        {
        }
    }
}
