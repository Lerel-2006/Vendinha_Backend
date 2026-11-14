using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Vendas.Models;

namespace Vendas.Contexts
{
    public class VendinhaDbContext : DbContext
    {
        private readonly string connectionString;

        public VendinhaDbContext(string connString)
        {
            connectionString = connString;
        }


        public VendinhaDbContext(DbContextOptions<VendinhaDbContext> options) : base(options)
        {
            connectionString = null;
        }

        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Dividas> Dividas => Set<Dividas>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //mapeamento das tabelas

            var entityCliente = modelBuilder.Entity<Cliente>();

            entityCliente.ToTable("clientes");
            entityCliente.HasKey(c => c.Id);

            entityCliente.Property(c => c.Id).HasColumnName("id");
            entityCliente.Property(c => c.Nome).HasColumnName("nome");
            entityCliente.Property(c => c.Cpf).HasColumnName("cpf");
            entityCliente.Property(c => c.DataNascimento).HasColumnName("data_nascimento")
                .HasColumnType("date");
            entityCliente.Property(c => c.Email).HasColumnName("email")
                .IsRequired(false);


            var entityDivida = modelBuilder.Entity<Dividas>();

            entityDivida.ToTable("dividas");
            entityDivida.HasKey(d => d.Id);

            entityDivida.Property(d => d.Id).HasColumnName("id");
            entityDivida.Property(d => d.IdCliente).HasColumnName("id_cliente");
            entityDivida.Property(d => d.NomeDaDivida).HasColumnName("nome_divida");
            entityDivida.Property(d => d.Valor).HasColumnName("valor")
                .HasPrecision(10, 2);
            entityDivida.Property(d => d.Situacao).HasColumnName("paga");
            entityDivida.Property(d => d.DataDeCriacao).HasColumnName("data_criacao")
                .HasColumnType("timestamp");
            entityDivida.Property(d => d.DataDePagamento).HasColumnName("data_pagamento")
                .HasColumnType("timestamp");

            //Relacionamento

            entityDivida.HasOne(d => d.Cliente)
                .WithMany()
                .HasForeignKey(d => d.IdCliente);

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured && !string.IsNullOrEmpty(connectionString))
            {
                optionsBuilder.UseNpgsql(connectionString).LogTo(message => Debug.WriteLine(message))
                    .EnableDetailedErrors();
            }

            base.OnConfiguring(optionsBuilder);
        }

    }
}
