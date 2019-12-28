using EcommerceLuiz.Dominio.Entidades;
using EcommerceLuiz.Dominio.ObjetoDeValor;
using EcommerceLuiz.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceLuiz.Repositorio.Contexto
{
    public class EcommerceLuizContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public EcommerceLuizContexto(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>()
                .HasData(new FormaPagamento()
                {
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Pagamento por Boleto"
                },
                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Cartão de Crédito",
                    Descricao = "Pagamento por Cartão de Crédito"
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Deposito",
                    Descricao = "Pagamento por Depósito"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
