﻿// <auto-generated />
using Exercicio_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Exercicio_1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250307001501_Cidade")]
    partial class Cidade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Exercicio_1.models.Cidade", b =>
                {
                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<int>("codigo")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Estado");

                    b.ToTable("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}
