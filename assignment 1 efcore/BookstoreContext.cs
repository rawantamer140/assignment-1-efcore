using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_1_efcore
{
    internal class BookstoreContext : DbContext
    {
        
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<category> Categories { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server=.\\MSSQLSERVER01;Database=bookstore;Trusted_Connection=True;TrustServerCertificate=True;"); 
                
        }
    }
}
   