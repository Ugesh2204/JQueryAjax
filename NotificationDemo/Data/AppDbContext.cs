using Microsoft.EntityFrameworkCore;
using NotificationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationDemo.Data
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7BGFQJH;Database=NotificationDemo;Trusted_Connection=True;");
        }

        public DbSet<Noti>Notis { get; set; }
        public DbSet<User>Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
