﻿// <auto-generated />
using Blazor_LeadManagement_HDIP.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blazor_LeadManagement_HDIP.Server.Migrations
{
    [DbContext(typeof(Blazor_LeadManagement_HDIP.Server.Data.AppContext))]
    [Migration("20220804184412_LeadData")]
    partial class LeadData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Blazor_LeadManagement_HDIP.Shared.Lead", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeadDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MyLeads");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CompanyName = "IBM",
                            CustomerEmail = "j.sheehan@ibm.com",
                            CustomerNumber = "0979282743",
                            FirstName = "John",
                            LastName = "Sheehan",
                            LeadDescription = "Attended Event: Blal blah"
                        },
                        new
                        {
                            ID = 2,
                            CompanyName = "Amazon",
                            CustomerEmail = "j.b@aws.com",
                            CustomerNumber = "097343433",
                            FirstName = "Jeff",
                            LastName = "Bezos",
                            LeadDescription = "Attended Event: AWS"
                        },
                        new
                        {
                            ID = 3,
                            CompanyName = "Tesla",
                            CustomerEmail = "elon.m@teslamotors.com",
                            CustomerNumber = "09792832323",
                            FirstName = "Elon",
                            LastName = "Musk",
                            LeadDescription = "Attended Event: AI and Ethics"
                        },
                        new
                        {
                            ID = 4,
                            CompanyName = "HSE",
                            CustomerEmail = "j.sheehan@hse.ie",
                            CustomerNumber = "0979282222",
                            FirstName = "Jenny",
                            LastName = "Sheehan",
                            LeadDescription = "Attended Event: Engineering for the future"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
