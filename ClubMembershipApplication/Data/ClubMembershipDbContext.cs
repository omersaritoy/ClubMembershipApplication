using ClubMembershipApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Data
{
    public class ClubMembershipDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ETicaret;User Id=Sa;Password=omer.21;TrustServerCertificate=True");
        }
        public DbSet<User> Users { get; set; }
    }
}
