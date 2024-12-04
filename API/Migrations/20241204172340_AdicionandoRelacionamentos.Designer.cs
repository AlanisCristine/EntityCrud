﻿// <auto-generated />
using System;
using Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241204172340_AdicionandoRelacionamentos")]
    partial class AdicionandoRelacionamentos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.36");

            modelBuilder.Entity("CrudEntity.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CidadeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("Infraestrutura.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroHabitantes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("Infraestrutura.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CrudEntity.Pessoa", b =>
                {
                    b.HasOne("Infraestrutura.Cidade", "Cidade")
                        .WithMany("Cidades")
                        .HasForeignKey("CidadeId");

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("Infraestrutura.Produto", b =>
                {
                    b.HasOne("CrudEntity.Pessoa", "Pessoa")
                        .WithMany("Produtos")
                        .HasForeignKey("PessoaId");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("CrudEntity.Pessoa", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Infraestrutura.Cidade", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}