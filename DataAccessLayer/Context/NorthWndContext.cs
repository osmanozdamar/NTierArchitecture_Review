using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DataAccessLayer.Context
{
    public class NorthWndContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Osman;Database=NorthWnd;Trusted_Connection=True;");
        }
    }


    
}
