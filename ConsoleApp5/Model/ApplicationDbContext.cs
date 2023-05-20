using ConsoleApp5.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Model
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Picture> Picture_p { get; set; }
        public DbSet<Author> Author_p { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Galary;Integrated Security=True");
        }
    }
}
