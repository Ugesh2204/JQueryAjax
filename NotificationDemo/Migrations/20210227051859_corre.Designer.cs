﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotificationDemo.Data;

namespace NotificationDemo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210227051859_corre")]
    partial class corre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotificationDemo.Models.Noti", b =>
                {
                    b.Property<int>("NotiId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("FromUserId");

                    b.Property<string>("FromUserName");

                    b.Property<bool>("IsRead");

                    b.Property<string>("Message");

                    b.Property<string>("NotiBody");

                    b.Property<string>("NotiHeader");

                    b.Property<int>("ToUserId");

                    b.Property<string>("ToUserName");

                    b.Property<string>("Url");

                    b.HasKey("NotiId");

                    b.ToTable("Notis");
                });

            modelBuilder.Entity("NotificationDemo.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
