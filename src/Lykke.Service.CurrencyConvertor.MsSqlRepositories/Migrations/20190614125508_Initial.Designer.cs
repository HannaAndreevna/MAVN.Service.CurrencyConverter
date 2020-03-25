﻿// <auto-generated />
using Lykke.Service.CurrencyConvertor.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.CurrencyConvertor.MsSqlRepositories.Migrations
{
    [DbContext(typeof(CurrencyContext))]
    [Migration("20190614125508_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("currency")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.CurrencyConvertor.MsSqlRepositories.Entities.CurrencyEntity", b =>
                {
                    b.Property<string>("CurrencyCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("currency_code")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("CurrencyLabel")
                        .HasColumnName("currency_label");

                    b.Property<decimal>("CurrencyRate")
                        .HasColumnName("currency_rate");

                    b.HasKey("CurrencyCode");

                    b.ToTable("currency");
                });
#pragma warning restore 612, 618
        }
    }
}