using LibraryDatabase.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Type = LibraryDatabase.DbModels.Type;

namespace LibraryDatabase
{
    public class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=LibraryDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Type> Types { get; set; }

        public virtual DbSet<BookType> BookTypes { get; set; }

    }
}
