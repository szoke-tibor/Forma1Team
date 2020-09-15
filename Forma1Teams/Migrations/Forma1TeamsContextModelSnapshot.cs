﻿// <auto-generated />
using Forma1Teams.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forma1Teams.Migrations
{
    [DbContext(typeof(F1Context))]
    partial class Forma1TeamsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Forma1Teams.Models.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EntryFeePaid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("WorldChampionNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearOfFoundation")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeamID");

                    b.ToTable("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
