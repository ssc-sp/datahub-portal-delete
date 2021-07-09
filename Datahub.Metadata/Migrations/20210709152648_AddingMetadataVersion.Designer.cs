﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NRCan.Datahub.Metadata;

namespace NRCan.Datahub.Metadata.Migrations
{
    [DbContext(typeof(MetadataDbContext))]
    [Migration("20210709152648_AddingMetadataVersion")]
    partial class AddingMetadataVersion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("NRCan.Datahub.Metadata.FieldChoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FieldDefinitionId")
                        .HasColumnType("int");

                    b.Property<string>("LabelEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabelFrench")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("FieldDefinitionId");

                    b.ToTable("FieldChoice");
                });

            modelBuilder.Entity("NRCan.Datahub.Metadata.FieldDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DescriptionEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionFrench")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFrench")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Required")
                        .HasColumnType("bit");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int>("VersionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FieldName")
                        .IsUnique();

                    b.HasIndex("VersionId");

                    b.ToTable("FieldDefinition");
                });

            modelBuilder.Entity("NRCan.Datahub.Metadata.MetadataVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<string>("VersionData")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("MetadataVersion");
                });

            modelBuilder.Entity("NRCan.Datahub.Metadata.FieldChoice", b =>
                {
                    b.HasOne("NRCan.Datahub.Metadata.FieldDefinition", "FieldDefinition")
                        .WithMany("Choices")
                        .HasForeignKey("FieldDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FieldDefinition");
                });

            modelBuilder.Entity("NRCan.Datahub.Metadata.FieldDefinition", b =>
                {
                    b.HasOne("NRCan.Datahub.Metadata.MetadataVersion", "Version")
                        .WithMany("Definitions")
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Version");
                });

            modelBuilder.Entity("NRCan.Datahub.Metadata.FieldDefinition", b =>
                {
                    b.Navigation("Choices");
                });

            modelBuilder.Entity("NRCan.Datahub.Metadata.MetadataVersion", b =>
                {
                    b.Navigation("Definitions");
                });
#pragma warning restore 612, 618
        }
    }
}
