using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mappings
{
    class ProdutosMapConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(p => p.Descricao).IsUnicode(false).IsRequired().HasMaxLength(100);

            builder.HasOne(p => p.Categoria).WithMany(c => c.Produtos).OnDelete(DeleteBehavior.NoAction); // desabilita a exclusão em cascata


        }
    }
}
