using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mappings
{
    class ItensVendaMapConfig : IEntityTypeConfiguration<ItensVenda>
    {
        public void Configure(EntityTypeBuilder<ItensVenda> builder)
        {
            // fazer com que a tabela itens venda tenha uma chave primaria composta
            builder.HasKey(i => new { i.ProdutoID, i.VendaID });
        }
    }
}
