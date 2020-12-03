using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Butuza_Elena_Lab8.Models;

namespace Butuza_Elena_Lab8.Data
{
    public class Butuza_Elena_Lab8Context : DbContext
    {
        public Butuza_Elena_Lab8Context (DbContextOptions<Butuza_Elena_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Butuza_Elena_Lab8.Models.Book> Book { get; set; }

        public DbSet<Butuza_Elena_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Butuza_Elena_Lab8.Models.Category> Category { get; set; }
    }
}
