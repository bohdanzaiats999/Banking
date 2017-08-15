using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Entity
{
    [Table("Credit")]
    class CreditEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public float Money { get; set; }
        public float InterestRate { get; set; }
        public float MonthlyPayment { get; set; }
        public bool AvailabilityCollateral { get; set; }
        public DateTime LastDateAccrued { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
