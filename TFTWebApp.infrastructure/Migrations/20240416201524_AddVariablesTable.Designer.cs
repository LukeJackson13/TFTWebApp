﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TFTWebApp.infrastructure;

#nullable disable

namespace TFTWebApp.infrastructure.Migrations
{
    [DbContext(typeof(TFTContext))]
    [Migration("20240416201524_AddVariablesTable")]
    partial class AddVariablesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("ChampionTrait", b =>
                {
                    b.Property<int>("ChampionsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TraitsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChampionsId", "TraitsId");

                    b.HasIndex("TraitsId");

                    b.ToTable("ChampionTrait");
                });

            modelBuilder.Entity("TFTWebApp.Core.Models.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "desc");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "icon");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.HasKey("Id");

                    b.ToTable("Abilities");

                    b.HasAnnotation("Relational:JsonPropertyName", "ability");
                });

            modelBuilder.Entity("TFTWebApp.Core.Models.Champion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AbilityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApiName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "apiName");

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "characterName");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "cost");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "icon");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("SquareIcon")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "squareIcon");

                    b.Property<int>("StatsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TileIcon")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "tileIcon");

                    b.HasKey("Id");

                    b.HasIndex("AbilityId");

                    b.HasIndex("StatsId");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("TFTWebApp.Core.Models.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Armor")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "armor");

                    b.Property<float?>("AttackSpeed")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "attackSpeed");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<float?>("CritChance")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "critChance");

                    b.Property<float>("CritMultiplier")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "critMultiplier");

                    b.Property<float?>("Damage")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "damage");

                    b.Property<float?>("Hp")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "hp");

                    b.Property<float>("InitialMana")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "initialMana");

                    b.Property<float?>("MagicResist")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "magicResist");

                    b.Property<float>("Mana")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "mana");

                    b.Property<float>("Range")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "range");

                    b.HasKey("Id");

                    b.ToTable("ChampionStats");

                    b.HasAnnotation("Relational:JsonPropertyName", "stats");
                });

            modelBuilder.Entity("TFTWebApp.Core.Models.Trait", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Traits");
                });

            modelBuilder.Entity("TFTWebApp.Core.Models.Variables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AbilityId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AbilityId");

                    b.ToTable("Variables");

                    b.HasAnnotation("Relational:JsonPropertyName", "variables");
                });

            modelBuilder.Entity("ChampionTrait", b =>
                {
                    b.HasOne("TFTWebApp.Core.Models.Champion", null)
                        .WithMany()
                        .HasForeignKey("ChampionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFTWebApp.Core.Models.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TFTWebApp.Core.Models.Champion", b =>
                {
                    b.HasOne("TFTWebApp.Core.Models.Ability", "Ability")
                        .WithMany()
                        .HasForeignKey("AbilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFTWebApp.Core.Models.Stats", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ability");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("TFTWebApp.Core.Models.Variables", b =>
                {
                    b.HasOne("TFTWebApp.Core.Models.Ability", null)
                        .WithMany("Variables")
                        .HasForeignKey("AbilityId");
                });

            modelBuilder.Entity("TFTWebApp.Core.Models.Ability", b =>
                {
                    b.Navigation("Variables");
                });
#pragma warning restore 612, 618
        }
    }
}
