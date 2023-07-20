﻿// <auto-generated />
using System;
using Bank_App_With_Team.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bank_App_With_Team.Migrations
{
    [DbContext(typeof(BankDBContext))]
    [Migration("20230720132103_changedfullnumbercolumn")]
    partial class changedfullnumbercolumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bank_App_With_Team.Entity.Bank", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.Card", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<decimal>("CashBack")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.Property<int>("Expiereyear")
                        .HasColumnType("int");

                    b.Property<int>("FirstEightNumber")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("BankId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.CardCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Cvv")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiereDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("FullNumber")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CardCustomers");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("customerId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.Card", b =>
                {
                    b.HasOne("Bank_App_With_Team.Entity.Bank", "Bank")
                        .WithMany("Cards")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.CardCustomer", b =>
                {
                    b.HasOne("Bank_App_With_Team.Entity.Card", "card")
                        .WithMany("Customer")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bank_App_With_Team.Entity.Customer", null)
                        .WithMany("cardCustomers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("card");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.Order", b =>
                {
                    b.HasOne("Bank_App_With_Team.Entity.Card", "card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bank_App_With_Team.Entity.Customer", "customer")
                        .WithMany("Orders")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("card");

                    b.Navigation("customer");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.Bank", b =>
                {
                    b.Navigation("Cards");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.Card", b =>
                {
                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Bank_App_With_Team.Entity.Customer", b =>
                {
                    b.Navigation("cardCustomers");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
