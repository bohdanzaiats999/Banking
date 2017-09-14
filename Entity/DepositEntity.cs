using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Entity
{
    [Table("Deposits")]
    class DepositEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Money { get; set; }
        public decimal InterestRate { get; set; }
        public DateTimeOffset LastDateAccrued { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
