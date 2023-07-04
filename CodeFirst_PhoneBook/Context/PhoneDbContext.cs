using CodeFirst_PhoneBook.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_PhoneBook.Context
{
    public class PhoneDbContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ALMALI\\OMERFDEV;Initial Catalog=PhoneBookDB;User ID=sa;pwd=Omer34;");
        }
    }
}
