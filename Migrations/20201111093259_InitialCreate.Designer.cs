﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Data;

namespace WebApp.Migrations
{
    [DbContext(typeof(WebAppContext))]
    [Migration("20201111093259_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.Autore", b =>
                {
                    b.Property<long>("AutoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FotoAutore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAutore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoriaAutore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoAutore")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutoreId");

                    b.ToTable("Autore");
                });

            modelBuilder.Entity("WebApp.Models.Opera", b =>
                {
                    b.Property<long>("OperaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AutoreId")
                        .HasColumnType("bigint");

                    b.Property<string>("Contesto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoOpera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Prezzo")
                        .HasColumnType("real");

                    b.Property<string>("Titolo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoOpera")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OperaId");

                    b.HasIndex("AutoreId");

                    b.ToTable("Opera");
                });

            modelBuilder.Entity("WebApp.Models.Personaggio", b =>
                {
                    b.Property<long>("PersonaggioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("OperaId")
                        .HasColumnType("bigint");

                    b.Property<string>("TestoPersonaggio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoPersonaggio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaggioId");

                    b.HasIndex("OperaId");

                    b.ToTable("Personaggio");
                });

            modelBuilder.Entity("WebApp.Models.Recensione", b =>
                {
                    b.Property<long>("RecensioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("OperaId")
                        .HasColumnType("bigint");

                    b.Property<string>("TestoRecensione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ValoreRecensione")
                        .HasColumnType("real");

                    b.HasKey("RecensioneId");

                    b.HasIndex("OperaId");

                    b.ToTable("Recensione");
                });

            modelBuilder.Entity("WebApp.Models.Opera", b =>
                {
                    b.HasOne("WebApp.Models.Autore", "Autore")
                        .WithMany("Opere")
                        .HasForeignKey("AutoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Personaggio", b =>
                {
                    b.HasOne("WebApp.Models.Opera", "Opera")
                        .WithMany("Personaggi")
                        .HasForeignKey("OperaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Recensione", b =>
                {
                    b.HasOne("WebApp.Models.Opera", "Opera")
                        .WithMany("Recensioni")
                        .HasForeignKey("OperaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
