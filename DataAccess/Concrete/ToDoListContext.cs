using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ToDoListContext: DbContext
    {
        public ToDoListContext()
        {
                
        }
        public virtual DbSet<Admin> Admins { get; set; }
        //Databaseye eşlenecek modeller buraya

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=.;Database=ToDoList;Trusted_Connection=True;TrustServerCertificate=True;");

    }
}
