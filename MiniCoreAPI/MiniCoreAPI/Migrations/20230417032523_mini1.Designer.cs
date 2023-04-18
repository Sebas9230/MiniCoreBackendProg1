﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinicoreCompras.Models;

#nullable disable

namespace MinicoreCompras.Migrations
{
    [DbContext(typeof(MiniCoreComprasContext))]
    [Migration("20230417032523_mini1")]
    partial class mini1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MinicoreCompras.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.HasKey("IdCliente")
                        .HasName("PK__clientes__885457EE3102FCF7");

                    b.ToTable("clientes", (string)null);
                });

            modelBuilder.Entity("MinicoreCompras.Models.Contrato", b =>
                {
                    b.Property<int>("IdContrato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idContrato");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdContrato"), 1L, 1);

                    b.Property<string>("Contratos")
                        .IsRequired()
                        .HasMaxLength(900)
                        .IsUnicode(false)
                        .HasColumnType("varchar(900)")
                        .HasColumnName("contratos");

                    b.Property<DateTime>("FechaContrato")
                        .HasColumnType("date")
                        .HasColumnName("fechaContrato");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.HasKey("IdContrato")
                        .HasName("PK__Contrato__91431FE1C0001ED1");

                    b.HasIndex("IdCliente");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("MinicoreCompras.Models.Contrato", b =>
                {
                    b.HasOne("MinicoreCompras.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Contratos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PersonOrder");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("MinicoreCompras.Models.Cliente", b =>
                {
                    b.Navigation("Contratos");
                });
#pragma warning restore 612, 618
        }
    }
}
