using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BankHub_6._7
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CreditAcc> CreditAccs { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<BankSeting> BankSeting { get; set; }
        public DbSet<UserOperation> UserOperations { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=Kirill.111;database=bankHub2db;",
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
