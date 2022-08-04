﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RewardsApp.SQLite.Data;

namespace RewardsApp.SQLite.Migrations
{
    [DbContext(typeof(RewardsAppContext))]
    [Migration("20210822021902_CustomerDetails")]
    partial class CustomerDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("RewardsApp.SQLite.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Number")
                        .IsUnique();

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("RewardsApp.SQLite.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastRedeemed")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LastRedeemedPoints")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Points")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReferrerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("ReferrerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RewardsApp.SQLite.Entities.Customer", b =>
                {
                    b.HasOne("RewardsApp.SQLite.Entities.Card", "Card")
                        .WithOne("Customer")
                        .HasForeignKey("RewardsApp.SQLite.Entities.Customer", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RewardsApp.SQLite.Entities.Customer", "Referrer")
                        .WithMany("ReferredCustomers")
                        .HasForeignKey("ReferrerId");

                    b.Navigation("Card");

                    b.Navigation("Referrer");
                });

            modelBuilder.Entity("RewardsApp.SQLite.Entities.Card", b =>
                {
                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RewardsApp.SQLite.Entities.Customer", b =>
                {
                    b.Navigation("ReferredCustomers");
                });
#pragma warning restore 612, 618
        }
    }
}
