﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiExamenAngulaNet.Entity;

namespace WebApiExamenAngulaNet.Migrations
{
    [DbContext(typeof(PostDbContext))]
    partial class PostDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("WebApiExamenAngulaNet.Entity.ControlEntrada", b =>
                {
                    b.Property<int>("IdControl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Asiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntradaSalida")
                        .HasColumnType("int");

                    b.Property<int>("EstadioIdEstadio")
                        .HasColumnType("int");

                    b.Property<int>("IdEntrada")
                        .HasColumnType("int");

                    b.Property<int>("IdHincha")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdControl");

                    b.HasIndex("EstadioIdEstadio");

                    b.ToTable("ControlEntrada");
                });

            modelBuilder.Entity("WebApiExamenAngulaNet.Entity.Entrada", b =>
                {
                    b.Property<int>("IdEntrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEntrada");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("WebApiExamenAngulaNet.Entity.Estadio", b =>
                {
                    b.Property<int>("IdEstadio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CapacidadPermitida")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadTotal")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Porcentaje")
                        .HasColumnType("int");

                    b.HasKey("IdEstadio");

                    b.ToTable("Estadio");
                });

            modelBuilder.Entity("WebApiExamenAngulaNet.Entity.Hincha", b =>
                {
                    b.Property<int>("IdHincha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHincha");

                    b.ToTable("Hincha");
                });

            modelBuilder.Entity("WebApiExamenAngulaNet.Entity.ControlEntrada", b =>
                {
                    b.HasOne("WebApiExamenAngulaNet.Entity.Estadio", null)
                        .WithMany("ControldeEntradas")
                        .HasForeignKey("EstadioIdEstadio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiExamenAngulaNet.Entity.Estadio", b =>
                {
                    b.Navigation("ControldeEntradas");
                });
#pragma warning restore 612, 618
        }
    }
}
