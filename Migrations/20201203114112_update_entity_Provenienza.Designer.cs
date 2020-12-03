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
    [Migration("20201203114112_update_entity_Provenienza")]
    partial class update_entity_Provenienza
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
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

            modelBuilder.Entity("WebApp.Models.Entities.BiancoENero.Provenienza", b =>
                {
                    b.Property<long>("ProvenienzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeVino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeZona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VinoNomeVino")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ZonaNomeZona")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProvenienzaId");

                    b.HasIndex("VinoNomeVino");

                    b.HasIndex("ZonaNomeZona");

                    b.ToTable("Provenienza");
                });

            modelBuilder.Entity("WebApp.Models.Entities.BiancoENero.Vino", b =>
                {
                    b.Property<string>("NomeVino")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CaratteristicheVino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoriaVino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoVino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZonaNomeZona")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NomeVino");

                    b.HasIndex("ZonaNomeZona");

                    b.ToTable("Vino");
                });

            modelBuilder.Entity("WebApp.Models.Entities.BiancoENero.Zona", b =>
                {
                    b.Property<string>("NomeZona")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NomeZona");

                    b.ToTable("Zona");
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

                    b.Property<int>("FiveStars")
                        .HasColumnType("int");

                    b.Property<string>("FotoOpera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FourStars")
                        .HasColumnType("int");

                    b.Property<int>("NumeroVoti")
                        .HasColumnType("int");

                    b.Property<int>("OneStars")
                        .HasColumnType("int");

                    b.Property<float>("Prezzo")
                        .HasColumnType("real");

                    b.Property<int>("ThreeStars")
                        .HasColumnType("int");

                    b.Property<string>("Titolo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoStars")
                        .HasColumnType("int");

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

                    b.Property<string>("NomePersonaggio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OperaId")
                        .HasColumnType("bigint");

                    b.Property<string>("TestoPersonaggio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoPersonaggio")
                        .IsRequired()
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

                    b.Property<string>("NomeRecensore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OperaId")
                        .HasColumnType("bigint");

                    b.Property<string>("TestoRecensione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titolo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ValoreRecensione")
                        .HasColumnType("real");

                    b.HasKey("RecensioneId");

                    b.HasIndex("OperaId");

                    b.ToTable("Recensione");
                });

            modelBuilder.Entity("WebApp.Models.Entities.BiancoENero.Provenienza", b =>
                {
                    b.HasOne("WebApp.Models.Entities.BiancoENero.Vino", "Vino")
                        .WithMany("Provenienze")
                        .HasForeignKey("VinoNomeVino");

                    b.HasOne("WebApp.Models.Entities.BiancoENero.Zona", "Zona")
                        .WithMany()
                        .HasForeignKey("ZonaNomeZona");
                });

            modelBuilder.Entity("WebApp.Models.Entities.BiancoENero.Vino", b =>
                {
                    b.HasOne("WebApp.Models.Entities.BiancoENero.Zona", null)
                        .WithMany("Vini")
                        .HasForeignKey("ZonaNomeZona");
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
