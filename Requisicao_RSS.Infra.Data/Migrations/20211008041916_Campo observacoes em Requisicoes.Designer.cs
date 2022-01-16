﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Requisicao_RSS.Infra.Data.Context;

namespace Requisicao_RSS.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211008041916_Campo observacoes em Requisicoes")]
    partial class CampoobservacoesemRequisicoes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.EntregaMaterial", b =>
                {
                    b.Property<int>("EntregaMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Divergencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("NomeFornecedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeCalcas")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeCamisas")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeLuvas")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("EntregaMaterialId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("EntregaMateriais");
                });

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("FornecedorId");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaseCalca")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("BaseCamisa")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("Registro")
                        .IsUnique();

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.Requisicao", b =>
                {
                    b.Property<int>("RequisicaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Data")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<string>("Divergencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeCalca")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeCamisa")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeLuva")
                        .HasColumnType("int");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TamanhoCalca")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TamanhoCamisa")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RequisicaoId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Requisicoes");
                });

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.RetiradaMaterial", b =>
                {
                    b.Property<int>("RetiradaMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Data")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("NomeFornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeCalcas")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeCamisas")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeLuvas")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("RetiradaMaterialId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("RetiradaMateriais");
                });

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.EntregaMaterial", b =>
                {
                    b.HasOne("Requisicao_RSS.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany("EntregaMateriais")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.Requisicao", b =>
                {
                    b.HasOne("Requisicao_RSS.Domain.Entities.Funcionario", "Funcionario")
                        .WithMany("Requisicoes")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.RetiradaMaterial", b =>
                {
                    b.HasOne("Requisicao_RSS.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany("RetiradaMateriais")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.Fornecedor", b =>
                {
                    b.Navigation("EntregaMateriais");

                    b.Navigation("RetiradaMateriais");
                });

            modelBuilder.Entity("Requisicao_RSS.Domain.Entities.Funcionario", b =>
                {
                    b.Navigation("Requisicoes");
                });
#pragma warning restore 612, 618
        }
    }
}
