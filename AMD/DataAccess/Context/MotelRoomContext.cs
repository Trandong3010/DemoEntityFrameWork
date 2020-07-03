using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class MotelRoomContext : DbContext
    {
        public DbSet<Categorys> Categoryses { get; set; }
        public DbSet<Rooms> Roomses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=MotelRoom; Trusted_Connection=True;");
        }


    }
}
