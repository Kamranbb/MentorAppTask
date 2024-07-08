﻿// <auto-generated />
using MentorAppTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MentorAppTask.Data.Migrations
{
    [DbContext(typeof(MentorAppDbContext))]
    partial class MentorAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MentorAppTask.Models.Pricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAdvanced")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeautured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Pricings");
                });

            modelBuilder.Entity("MentorAppTask.Models.PricingService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PricingId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PricingId");

                    b.HasIndex("ServiceId");

                    b.ToTable("PricingServices");
                });

            modelBuilder.Entity("MentorAppTask.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("MentorAppTask.Models.PricingService", b =>
                {
                    b.HasOne("MentorAppTask.Models.Pricing", "Pricing")
                        .WithMany("PricingServices")
                        .HasForeignKey("PricingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MentorAppTask.Models.Service", "Service")
                        .WithMany("PricingServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pricing");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("MentorAppTask.Models.Pricing", b =>
                {
                    b.Navigation("PricingServices");
                });

            modelBuilder.Entity("MentorAppTask.Models.Service", b =>
                {
                    b.Navigation("PricingServices");
                });
#pragma warning restore 612, 618
        }
    }
}
