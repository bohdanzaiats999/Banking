﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Entity
{
    class AccountEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public float Money { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}