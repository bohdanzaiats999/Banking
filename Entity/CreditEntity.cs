using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Entity
{
    [Table("Credits")]
    class CreditEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Money { get; set; }
        public decimal InterestRate { get; set; }
        public decimal MonthlyPayment { get; set; }
        public bool AvailabilityCollateral { get; set; }
        public DateTimeOffset LastDateAccrued { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
