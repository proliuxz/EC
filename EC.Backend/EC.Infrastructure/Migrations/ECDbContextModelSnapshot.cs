﻿// <auto-generated />
using EC.Core.Entities;
using EC.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EC.Infrastructure.Migrations
{
    [DbContext(typeof(ECDbContext))]
    partial class ECDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EC.Core.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndTime");

                    b.Property<Guid?>("HostId");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EC.Core.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("EventId");

                    b.Property<string>("LoginName");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("EC.Core.Entities.Event", b =>
                {
                    b.HasOne("EC.Core.Entities.Player", "Host")
                        .WithMany()
                        .HasForeignKey("HostId");
                });

            modelBuilder.Entity("EC.Core.Entities.Player", b =>
                {
                    b.HasOne("EC.Core.Entities.Event")
                        .WithMany("Players")
                        .HasForeignKey("EventId");
                });
#pragma warning restore 612, 618
        }
    }
}
