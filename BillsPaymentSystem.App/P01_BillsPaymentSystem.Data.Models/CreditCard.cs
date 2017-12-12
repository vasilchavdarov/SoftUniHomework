using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }
        public decimal Limit { get; set; }
        public decimal MoneyOwed { get; set; }
        public DateTime ExpirationDate { get; set; }

        public decimal LimitLeft => this.Limit - this.MoneyOwed;

        public int PaymantMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
