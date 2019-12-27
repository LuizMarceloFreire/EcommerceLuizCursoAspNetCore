using EcommerceLuiz.Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceLuiz.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(formapagamento => formapagamento.Id);

            builder
                .Property(formapagamento => formapagamento.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(formapagamento => formapagamento.Descricao)
                .IsRequired()
                .HasMaxLength(400);
        }
    }
}
