﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp.Entity
{
    public class Operation
    {
        public DateTime Date { get; set; }
        public User User { get; set; }
        public User Cashier { get; set; }
        public OperationType Type { get; set; }
        public Currency UserCurrency { get; set; }
        public BigInteger UserAmount { get; set; }
        public Currency TargetCurrency { get; set; }
        public BigInteger TargetAmount { get; set; }

        public Operation(DateTime date, User user, OperationType type, Currency userCurrency, BigInteger userAmount, Currency targetCurrency, BigInteger targetAmount, User cashier)
        {
            Date = date;
            User = user;
            Cashier = cashier;
            Type = type;
            this.UserCurrency = userCurrency;
            this.UserAmount = userAmount;
            this.TargetCurrency = targetCurrency;
            this.TargetAmount = targetAmount;
        }
    }
}