﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portifolio.Data;

namespace Portifolio675.Migrations
{
    [DbContext(typeof(PortDbContext))]
    [Migration("20210917162756_v456465")]
    partial class v456465
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portifolio.Models.Categ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProdId")
                        .HasColumnType("int");

                    b.Property<string>("TipoProduto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProdId");

                    b.ToTable("Categs");
                });

            modelBuilder.Entity("Portifolio.Models.Prod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AnoFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CategId")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataLacamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategId");

                    b.ToTable("Prods");
                });

            modelBuilder.Entity("Portifolio.Models.Categ", b =>
                {
                    b.HasOne("Portifolio.Models.Prod", null)
                        .WithMany("Categs")
                        .HasForeignKey("ProdId");
                });

            modelBuilder.Entity("Portifolio.Models.Prod", b =>
                {
                    b.HasOne("Portifolio.Models.Categ", "Categ")
                        .WithMany("Prods")
                        .HasForeignKey("CategId");

                    b.Navigation("Categ");
                });

            modelBuilder.Entity("Portifolio.Models.Categ", b =>
                {
                    b.Navigation("Prods");
                });

            modelBuilder.Entity("Portifolio.Models.Prod", b =>
                {
                    b.Navigation("Categs");
                });
#pragma warning restore 612, 618
        }
    }
}
