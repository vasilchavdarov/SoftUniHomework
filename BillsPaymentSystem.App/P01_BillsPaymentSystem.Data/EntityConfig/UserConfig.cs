using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);

            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);

            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Email).IsRequired().IsUnicode(false).HasMaxLength(80);

            builder.Property(e => e.Password).IsRequired().IsUnicode(false).HasMaxLength(25);
        }
    }
}
