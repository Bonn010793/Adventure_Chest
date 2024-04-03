using System;
using Adventure_Chest.Models;
using Microsoft.EntityFrameworkCore;
namespace Adventure_Chest.DB
{
	public class ApplicationContext :DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

