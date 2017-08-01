using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Banking.Model;

namespace Banking.DAL
{
    class BankingContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CurrentAccount> CurrentAccounts { get; set; }
        public DbSet<DepositAccount> DepositAccounts { get; set; }
        public DbSet<CreditAccount> CreditAccounts { get; set; }
    }
}
