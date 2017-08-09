using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Entity
{
    class UserEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<AccountEntity> Accounts { get; set; }
        public ICollection<DepositEntity> Deposits{ get; set; }
        public ICollection<CreditEntity> Credits { get; set; }

        public UserEntity()
        {
            Accounts = new List<AccountEntity>();
            Deposits = new List<DepositEntity>();
            Credits = new List<CreditEntity>();
        }
    }
}
