﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PriceCalculatorPOC;

#nullable disable

namespace PriceCalculatorPOC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PriceCalculatorPOC.Models.CustomizationFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InteriorElementId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InteriorElementId");

                    b.ToTable("CustomizationFeatures");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.FeatureField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomizationFeatureId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomizationFeatureId");

                    b.ToTable("FeatureFields");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.FixedUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FixedUnits");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.FixedUnitField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FixedUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FixedUnitId");

                    b.ToTable("FixedUnitFields");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.InteriorElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("InteriorElements");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.Selection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.PrimitiveCollection<string>("SelectedCustomizationFeatureIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("SelectedFeatureFieldIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("SelectedFixedUnitFieldIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("SelectedFixedUnitIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("SelectedInteriorElementIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Selections");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.CustomizationFeature", b =>
                {
                    b.HasOne("PriceCalculatorPOC.Models.InteriorElement", "InteriorElement")
                        .WithMany("CustomizationFeatures")
                        .HasForeignKey("InteriorElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InteriorElement");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.FeatureField", b =>
                {
                    b.HasOne("PriceCalculatorPOC.Models.CustomizationFeature", "CustomizationFeature")
                        .WithMany("FeatureFields")
                        .HasForeignKey("CustomizationFeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomizationFeature");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.FixedUnitField", b =>
                {
                    b.HasOne("PriceCalculatorPOC.Models.FixedUnit", "FixedUnit")
                        .WithMany("FixedUnitFields")
                        .HasForeignKey("FixedUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FixedUnit");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.InteriorElement", b =>
                {
                    b.HasOne("PriceCalculatorPOC.Models.Room", "Room")
                        .WithMany("InteriorElements")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.Selection", b =>
                {
                    b.HasOne("PriceCalculatorPOC.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.CustomizationFeature", b =>
                {
                    b.Navigation("FeatureFields");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.FixedUnit", b =>
                {
                    b.Navigation("FixedUnitFields");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.InteriorElement", b =>
                {
                    b.Navigation("CustomizationFeatures");
                });

            modelBuilder.Entity("PriceCalculatorPOC.Models.Room", b =>
                {
                    b.Navigation("InteriorElements");
                });
#pragma warning restore 612, 618
        }
    }
}
