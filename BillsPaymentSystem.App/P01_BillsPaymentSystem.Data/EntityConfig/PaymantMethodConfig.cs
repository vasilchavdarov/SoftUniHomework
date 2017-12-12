using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using P01_BillsPaymentSystem.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    class PaymantMethodConfig : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => new { e.UserId, e.BankAccountId, e.CreditCardId }).IsUnique();

            builder.HasOne(e => e.User).WithMany(u => u.PaymentMethods).HasForeignKey(e => e.UserId);

            builder.HasOne(e => e.CreditCard).WithOne(cr => cr.PaymentMethod).HasForeignKey<PaymentMethod>(e => e.CreditCardId);

            builder.HasOne(e => e.BankAccount).WithOne(ba => ba.PaymentMethod).HasForeignKey<PaymentMethod>(e => e.BankAccountId);
        }
    }
}
