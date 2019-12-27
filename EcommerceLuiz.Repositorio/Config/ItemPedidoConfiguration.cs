using EcommerceLuiz.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceLuiz.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(itempedido => itempedido.Id);

            builder
                .Property(itempedido => itempedido.Quantidade)
                .IsRequired();

            builder
                .Property(itempedido => itempedido.ProdutoId)
                .IsRequired();
        }
    }
}
