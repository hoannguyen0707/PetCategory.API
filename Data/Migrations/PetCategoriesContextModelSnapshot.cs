﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetCategory.API.Data;

#nullable disable

namespace PetCategory.API.Data.Migrations
{
    [DbContext(typeof(PetCategoriesContext))]
    partial class PetCategoriesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1");

            modelBuilder.Entity("PetCategory.API.Entities.PetCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Loyal and friendly companion",
                            Name = "Dog"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Independent and playful",
                            Name = "Cat"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Colorful and sings beautifully",
                            Name = "Bird"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Quiet, easy-care pet",
                            Name = "Fish"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Gentle and soft-furred",
                            Name = "Rabbit"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
