﻿// <auto-generated />
using System;
using Example.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Example.DataAccessLayer.Migrations.SqlLite
{
    [DbContext(typeof(SqlLiteContext))]
    [Migration("20220707072330_migrate1")]
    partial class migrate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Example.Entites.concrete.Invoice", b =>
                {
                    b.Property<int>("LogicalRef")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DocNum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Number")
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.HasKey("LogicalRef");

                    b.ToTable("Invoice");
                });
#pragma warning restore 612, 618
        }
    }
}
