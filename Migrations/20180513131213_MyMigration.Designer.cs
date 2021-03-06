﻿// <auto-generated />
using EvilLyo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EvilLyo.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180513131213_MyMigration")]
    partial class MyMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("EvilLyo.Models.picture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int>("Count");

                    b.Property<string>("Title");

                    b.Property<string>("Type1");

                    b.Property<string>("Type2");

                    b.Property<string>("URL");

                    b.Property<string>("col1");

                    b.Property<string>("col2");

                    b.Property<string>("col3");

                    b.Property<string>("col4");

                    b.Property<string>("col5");

                    b.HasKey("ID");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("EvilLyo.Models.story", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int>("Count");

                    b.Property<string>("Title");

                    b.Property<string>("Type1");

                    b.Property<string>("Type2");

                    b.Property<string>("URL");

                    b.Property<string>("col1");

                    b.Property<string>("col2");

                    b.Property<string>("col3");

                    b.Property<string>("col4");

                    b.Property<string>("col5");

                    b.HasKey("ID");

                    b.ToTable("Storys");
                });

            modelBuilder.Entity("EvilLyo.Models.video", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int>("Count");

                    b.Property<string>("Title");

                    b.Property<string>("Type1");

                    b.Property<string>("Type2");

                    b.Property<string>("URL");

                    b.Property<string>("col1");

                    b.Property<string>("col2");

                    b.Property<string>("col3");

                    b.Property<string>("col4");

                    b.Property<string>("col5");

                    b.HasKey("ID");

                    b.ToTable("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}
