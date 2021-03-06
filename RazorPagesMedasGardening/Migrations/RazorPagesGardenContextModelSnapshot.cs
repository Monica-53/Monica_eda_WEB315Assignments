// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedasGardening.Migrations
{
    [DbContext(typeof(RazorPagesGardenContext))]
    partial class RazorPagesGardenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("RazorPagesGarden.Models.Garden", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PriceOfSeeds")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeOfGarden")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("plantingDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Garden");
                });
#pragma warning restore 612, 618
        }
    }
}
