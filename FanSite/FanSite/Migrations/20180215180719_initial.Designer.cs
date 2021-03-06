﻿// <auto-generated />
using FanSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FanSite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180215180719_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FanSite.Models.StoryModel", b =>
                {
                    b.Property<int>("StoryModelID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Story");

                    b.Property<string>("Title");

                    b.HasKey("StoryModelID");

                    b.ToTable("Storys");
                });
#pragma warning restore 612, 618
        }
    }
}
