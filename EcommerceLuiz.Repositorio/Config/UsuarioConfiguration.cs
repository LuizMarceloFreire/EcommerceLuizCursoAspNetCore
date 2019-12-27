using EcommerceLuiz.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceLuiz.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(usuario => usuario.Id);

            builder
                .Property(usuario => usuario.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(usuario => usuario.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(usuario => usuario.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(usuario => usuario.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .HasMany(usuarios => usuarios.Pedidos)
                .WithOne(pedido => pedido.Usuario);

        }
    }
}
