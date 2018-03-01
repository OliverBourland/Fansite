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
    [Migration("20180301225025_Identity")]
    partial class Identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FanSite.Models.Fan", b =>
                {
                    b.Property<int>("FanID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int>("StoryModelID");

                    b.HasKey("FanID");

                    b.HasIndex("StoryModelID");

                    b.ToTable("Fans");
                });

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

            modelBuilder.Entity("FanSite.Models.Fan", b =>
                {
                    b.HasOne("FanSite.Models.StoryModel")
                        .WithMany("Fans")
                        .HasForeignKey("StoryModelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}