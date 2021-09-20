using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mappings
{
    class ClienteMapConfig : IEntityTypeConfiguration<ClienteBLL>
    {
        public void Configure(EntityTypeBuilder<ClienteBLL> builder)
        {
            builder.Property(c => c.Nome).IsUnicode(false).IsRequired().HasMaxLength(70);
            builder.Property(c => c.Email).IsUnicode(false).IsRequired().HasMaxLength(100);
            builder.Property(c => c.CPF).IsUnicode(false).IsRequired().IsFixedLength().HasMaxLength(11);

            builder.HasIndex(c => c.CPF).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();
        }
    }
}
