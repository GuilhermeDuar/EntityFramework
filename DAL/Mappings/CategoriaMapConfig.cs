using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mappings
{
    // internal é o padrão, só vista dentro do dal
    internal class CategoriaMapConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
                // descricao varchar(50) not null
                builder.Property(c => c.Descricao).IsRequired().IsUnicode(false).HasMaxLength(50);
                // adiciona unique na linha acima
                builder.HasIndex(c => c.Descricao).IsUnique(true);
            
        }
    }
}
