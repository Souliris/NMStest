﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NMStest.Data;

namespace NMStest.Migrations
{
    [DbContext(typeof(NMScontext))]
    partial class NMScontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NMStest.Models.Planet", b =>
                {
                    b.Property<int>("PlanetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasAcientBones");

                    b.Property<bool>("HasSalvageScrap");

                    b.Property<string>("PlanetName");

                    b.Property<string>("Sentinels");

                    b.Property<int?>("planetResource1ResourceId");

                    b.Property<int?>("planetResource2ResourceId");

                    b.Property<int?>("planetResource3ResourceId");

                    b.Property<int?>("planetResource4ResourceId");

                    b.HasKey("PlanetId");

                    b.HasIndex("planetResource1ResourceId");

                    b.HasIndex("planetResource2ResourceId");

                    b.HasIndex("planetResource3ResourceId");

                    b.HasIndex("planetResource4ResourceId");

                    b.ToTable("Planet");
                });

            modelBuilder.Entity("NMStest.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("resourceName");

                    b.HasKey("ResourceId");

                    b.ToTable("Resource");
                });

            modelBuilder.Entity("NMStest.Models.StarSystems", b =>
                {
                    b.Property<int>("SystemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConflictType");

                    b.Property<string>("EconomyType");

                    b.Property<int?>("Planet1PlanetId");

                    b.Property<int?>("Planet2PlanetId");

                    b.Property<int?>("Planet3PlanetId");

                    b.Property<int?>("Planet4PlanetId");

                    b.Property<int?>("Planet5PlanetId");

                    b.Property<int?>("Planet6PlanetId");

                    b.Property<int?>("Planet7PlanetId");

                    b.Property<int?>("Planet8PlanetId");

                    b.Property<int?>("Planet9PlanetId");

                    b.Property<string>("StarType");

                    b.Property<string>("SystemName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("SystemId");

                    b.HasIndex("Planet1PlanetId");

                    b.HasIndex("Planet2PlanetId");

                    b.HasIndex("Planet3PlanetId");

                    b.HasIndex("Planet4PlanetId");

                    b.HasIndex("Planet5PlanetId");

                    b.HasIndex("Planet6PlanetId");

                    b.HasIndex("Planet7PlanetId");

                    b.HasIndex("Planet8PlanetId");

                    b.HasIndex("Planet9PlanetId");

                    b.ToTable("StarSystems");
                });

            modelBuilder.Entity("NMStest.Models.Planet", b =>
                {
                    b.HasOne("NMStest.Models.Resource", "planetResource1")
                        .WithMany()
                        .HasForeignKey("planetResource1ResourceId");

                    b.HasOne("NMStest.Models.Resource", "planetResource2")
                        .WithMany()
                        .HasForeignKey("planetResource2ResourceId");

                    b.HasOne("NMStest.Models.Resource", "planetResource3")
                        .WithMany()
                        .HasForeignKey("planetResource3ResourceId");

                    b.HasOne("NMStest.Models.Resource", "planetResource4")
                        .WithMany()
                        .HasForeignKey("planetResource4ResourceId");
                });

            modelBuilder.Entity("NMStest.Models.StarSystems", b =>
                {
                    b.HasOne("NMStest.Models.Planet", "Planet1")
                        .WithMany()
                        .HasForeignKey("Planet1PlanetId");

                    b.HasOne("NMStest.Models.Planet", "Planet2")
                        .WithMany()
                        .HasForeignKey("Planet2PlanetId");

                    b.HasOne("NMStest.Models.Planet", "Planet3")
                        .WithMany()
                        .HasForeignKey("Planet3PlanetId");

                    b.HasOne("NMStest.Models.Planet", "Planet4")
                        .WithMany()
                        .HasForeignKey("Planet4PlanetId");

                    b.HasOne("NMStest.Models.Planet", "Planet5")
                        .WithMany()
                        .HasForeignKey("Planet5PlanetId");

                    b.HasOne("NMStest.Models.Planet", "Planet6")
                        .WithMany()
                        .HasForeignKey("Planet6PlanetId");

                    b.HasOne("NMStest.Models.Planet", "Planet7")
                        .WithMany()
                        .HasForeignKey("Planet7PlanetId");

                    b.HasOne("NMStest.Models.Planet", "Planet8")
                        .WithMany()
                        .HasForeignKey("Planet8PlanetId");

                    b.HasOne("NMStest.Models.Planet", "Planet9")
                        .WithMany()
                        .HasForeignKey("Planet9PlanetId");
                });
#pragma warning restore 612, 618
        }
    }
}
