using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Banking.Entity;

namespace Banking.DAL
{
    class BankingContext : DbContext 
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AccountEntity> Accounts { get; set; }
        public DbSet<DepositEntity> Deposits { get; set; }
        public DbSet<CreditEntity> Credits { get; set; }
    }
}
