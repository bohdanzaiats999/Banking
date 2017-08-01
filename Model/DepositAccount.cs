using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Model
{
    class DepositAccount
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public float Money { get; set; }
        public float InterestRate { get; set; }
        public DateTime LastDateAccrued { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
