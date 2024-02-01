using Expenses.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Expenses.DataLayer
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }
        public DbSet<ExpenseModel> ExpenseModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpenseModel>()
                .Property(e => e.MoneySpent)
                .HasColumnType("decimal(18,2)"); // Adjust precision and scale accordingly

            // Other configurations...

            base.OnModelCreating(modelBuilder);
        }
    }
}
