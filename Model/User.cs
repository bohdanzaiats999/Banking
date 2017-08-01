using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Model
{
    class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<CurrentAccount> CurrentAccounts { get; set; }
        public ICollection<DepositAccount> DepositCreditAccounts { get; set; }

        public User()
        {
            CurrentAccounts = new List<CurrentAccount>();
            DepositCreditAccounts = new List<DepositAccount>();
        }
    }
}
