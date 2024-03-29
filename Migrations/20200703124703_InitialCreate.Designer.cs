﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jrascraping.Models;

namespace jrascraping.Migrations
{
    [DbContext(typeof(JraDbContext))]
    [Migration("20200703124703_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("jrascraping.Models.CnameTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Racename")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CnameTable");
                });

            modelBuilder.Entity("jrascraping.Models.HorseInfo", b =>
                {
                    b.Property<string>("HorseName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoatColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Father")
                        .HasColumnType("TEXT");

                    b.Property<string>("HorseNameMeaning")
                        .HasColumnType("TEXT");

                    b.Property<string>("HorseOwner")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mother")
                        .HasColumnType("TEXT");

                    b.Property<string>("MotherFather")
                        .HasColumnType("TEXT");

                    b.Property<string>("MotherMother")
                        .HasColumnType("TEXT");

                    b.Property<string>("Origin")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductionRanch")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<string>("Trainer")
                        .HasColumnType("TEXT");

                    b.HasKey("HorseName", "Birthday");

                    b.ToTable("HorseInfo");
                });

            modelBuilder.Entity("jrascraping.Models.PayBack", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Fuku1Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fuku1HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Fuku1Num")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Fuku1Re")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Fuku2Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fuku2HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Fuku2Num")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Fuku2Re")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Fuku3Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fuku3HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Fuku3Num")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Fuku3Re")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Sanfuku1Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sanfuku1HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Sanfuku1Num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Sanfuku2Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sanfuku2HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Sanfuku2Num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Sanfuku3Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sanfuku3HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Sanfuku3Num")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SanfukuRe")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Santan1Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Santan1HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Santan1Num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Santan2Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Santan2HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Santan2Num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Santan3Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Santan3HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Santan3Num")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SantanRe")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("TanshoBirthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("TanshoHorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TanshoNum")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TanshoRe")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Umaren1Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Umaren1HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Umaren1Num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Umaren2Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Umaren2HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Umaren2Num")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UmarenRe")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Umatan1Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Umatan1HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Umatan1Num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Umatan2Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Umatan2HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Umatan2Num")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UmatanRe")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Wakuren1Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wakuren1HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Wakuren1Waku")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Wakuren2Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wakuren2HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Wakuren2Waku")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WakurenRe")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Wide1Re")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Wide1_1Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wide1_1HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Wide1_1Num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Wide1_2Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wide1_2HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Wide1_2Num")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Wide2Re")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Wide2_1Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wide2_1HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Wide2_1Num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Wide2_2Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wide2_2HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Wide2_2Num")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Wide3Re")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Wide3_1Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wide3_1HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Wide3_1Num")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Wide3_2Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Wide3_2HorseName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Wide3_2Num")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("Fuku1HorseName", "Fuku1Birthday");

                    b.HasIndex("Fuku2HorseName", "Fuku2Birthday");

                    b.HasIndex("Fuku3HorseName", "Fuku3Birthday");

                    b.HasIndex("Sanfuku1HorseName", "Sanfuku1Birthday");

                    b.HasIndex("Sanfuku2HorseName", "Sanfuku2Birthday");

                    b.HasIndex("Sanfuku3HorseName", "Sanfuku3Birthday");

                    b.HasIndex("Santan1HorseName", "Santan1Birthday");

                    b.HasIndex("Santan2HorseName", "Santan2Birthday");

                    b.HasIndex("Santan3HorseName", "Santan3Birthday");

                    b.HasIndex("TanshoHorseName", "TanshoBirthday");

                    b.HasIndex("Umaren1HorseName", "Umaren1Birthday");

                    b.HasIndex("Umaren2HorseName", "Umaren2Birthday");

                    b.HasIndex("Umatan1HorseName", "Umatan1Birthday");

                    b.HasIndex("Umatan2HorseName", "Umatan2Birthday");

                    b.HasIndex("Wakuren1HorseName", "Wakuren1Birthday");

                    b.HasIndex("Wakuren2HorseName", "Wakuren2Birthday");

                    b.HasIndex("Wide1_1HorseName", "Wide1_1Birthday");

                    b.HasIndex("Wide1_2HorseName", "Wide1_2Birthday");

                    b.HasIndex("Wide2_1HorseName", "Wide2_1Birthday");

                    b.HasIndex("Wide2_2HorseName", "Wide2_2Birthday");

                    b.HasIndex("Wide3_1HorseName", "Wide3_1Birthday");

                    b.HasIndex("Wide3_2HorseName", "Wide3_2Birthday");

                    b.ToTable("PayBack");
                });

            modelBuilder.Entity("jrascraping.Models.RaceInfo", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Around")
                        .HasColumnType("TEXT");

                    b.Property<string>("Baba")
                        .HasColumnType("TEXT");

                    b.Property<string>("BabaState")
                        .HasColumnType("TEXT");

                    b.Property<string>("Distance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Holding")
                        .HasColumnType("TEXT");

                    b.Property<string>("OldClass")
                        .HasColumnType("TEXT");

                    b.Property<string>("RaceName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RefundID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShippingTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Weather")
                        .HasColumnType("TEXT");

                    b.HasKey("Date");

                    b.HasIndex("RefundID");

                    b.ToTable("RaceInfo");
                });

            modelBuilder.Entity("jrascraping.Models.RaceResult", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("RaceName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Num")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Place")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArrivalDifference")
                        .HasColumnType("TEXT");

                    b.Property<string>("Corner")
                        .HasColumnType("TEXT");

                    b.Property<string>("HalongTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Holding")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("HorseBirthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("HorseName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HorseWeight")
                        .HasColumnType("TEXT");

                    b.Property<string>("Jockey")
                        .HasColumnType("TEXT");

                    b.Property<string>("Margin")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Pop")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShippingTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("Trainer")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Waku")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Date", "RaceName", "Num", "Place");

                    b.HasIndex("HorseName", "HorseBirthday");

                    b.ToTable("RaceResults");
                });

            modelBuilder.Entity("jrascraping.Models.PayBack", b =>
                {
                    b.HasOne("jrascraping.Models.HorseInfo", "Fuku1")
                        .WithMany()
                        .HasForeignKey("Fuku1HorseName", "Fuku1Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Fuku2")
                        .WithMany()
                        .HasForeignKey("Fuku2HorseName", "Fuku2Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Fuku3")
                        .WithMany()
                        .HasForeignKey("Fuku3HorseName", "Fuku3Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Sanfuku1")
                        .WithMany()
                        .HasForeignKey("Sanfuku1HorseName", "Sanfuku1Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Sanfuku2")
                        .WithMany()
                        .HasForeignKey("Sanfuku2HorseName", "Sanfuku2Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Sanfuku3")
                        .WithMany()
                        .HasForeignKey("Sanfuku3HorseName", "Sanfuku3Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Santan1")
                        .WithMany()
                        .HasForeignKey("Santan1HorseName", "Santan1Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Santan2")
                        .WithMany()
                        .HasForeignKey("Santan2HorseName", "Santan2Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Santan3")
                        .WithMany()
                        .HasForeignKey("Santan3HorseName", "Santan3Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Tansho")
                        .WithMany()
                        .HasForeignKey("TanshoHorseName", "TanshoBirthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Umaren1")
                        .WithMany()
                        .HasForeignKey("Umaren1HorseName", "Umaren1Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Umaren2")
                        .WithMany()
                        .HasForeignKey("Umaren2HorseName", "Umaren2Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Umatan1")
                        .WithMany()
                        .HasForeignKey("Umatan1HorseName", "Umatan1Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Umatan2")
                        .WithMany()
                        .HasForeignKey("Umatan2HorseName", "Umatan2Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Wakuren1")
                        .WithMany()
                        .HasForeignKey("Wakuren1HorseName", "Wakuren1Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Wakuren2")
                        .WithMany()
                        .HasForeignKey("Wakuren2HorseName", "Wakuren2Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Wide1_1")
                        .WithMany()
                        .HasForeignKey("Wide1_1HorseName", "Wide1_1Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Wide1_2")
                        .WithMany()
                        .HasForeignKey("Wide1_2HorseName", "Wide1_2Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Wide2_1")
                        .WithMany()
                        .HasForeignKey("Wide2_1HorseName", "Wide2_1Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Wide2_2")
                        .WithMany()
                        .HasForeignKey("Wide2_2HorseName", "Wide2_2Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Wide3_1")
                        .WithMany()
                        .HasForeignKey("Wide3_1HorseName", "Wide3_1Birthday");

                    b.HasOne("jrascraping.Models.HorseInfo", "Wide3_2")
                        .WithMany()
                        .HasForeignKey("Wide3_2HorseName", "Wide3_2Birthday");
                });

            modelBuilder.Entity("jrascraping.Models.RaceInfo", b =>
                {
                    b.HasOne("jrascraping.Models.PayBack", "Refund")
                        .WithMany()
                        .HasForeignKey("RefundID");
                });

            modelBuilder.Entity("jrascraping.Models.RaceResult", b =>
                {
                    b.HasOne("jrascraping.Models.HorseInfo", "Horse")
                        .WithMany()
                        .HasForeignKey("HorseName", "HorseBirthday");
                });
#pragma warning restore 612, 618
        }
    }
}
