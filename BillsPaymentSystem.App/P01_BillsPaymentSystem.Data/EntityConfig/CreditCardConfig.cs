﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    class CreditCardConfig : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.HasKey(e => e.CreditCardId);

            builder.Ignore(e => e.LimitLeft);

            builder.Ignore(e => e.PaymantMethodId);
        }
    }
}
