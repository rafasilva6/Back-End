﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _18_Crud_Bd.Context;

#nullable disable

namespace _18_Crud_Bd.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231002131736_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("_18_Crud_Bd.Models.Jogo", b =>
                {
                    b.Property<int>("JogoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Descricao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Imagem")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("INTEGER");

                    b.HasKey("JogoId");

                    b.ToTable("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}
