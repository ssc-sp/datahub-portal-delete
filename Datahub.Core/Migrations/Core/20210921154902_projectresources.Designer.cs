﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Datahub.Core.UserTracking;

namespace Datahub.Core.Migrations.Core
{
    [DbContext(typeof(DatahubProjectDBContext))]
    [Migration("20210921154902_projectresources")]
    partial class projectresources
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project", b =>
                {
                    b.Property<int>("Project_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Branch_Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Comments_NT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_List")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DB_Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("DB_Server")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("DB_Type")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Data_Sensitivity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Databricks_URL")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<DateTime?>("Deleted_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Division_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GC_Docs_URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Initial_Meeting_DT")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Is_Featured")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_Private")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Last_Contact_DT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Last_Updated_DT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Next_Meeting_DT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Number_Of_Users_Involved")
                        .HasColumnType("int");

                    b.Property<string>("PowerBI_URL")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Project_Acronym_CD")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Project_Admin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project_Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project_Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project_Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Project_Name_Fr")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Project_Phase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project_Status_Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project_Summary_Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project_Summary_Desc_Fr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector_Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Stage_Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("WebForms_URL")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Project_ID");

                    b.ToTable("Projects");

                    b.HasCheckConstraint("CHK_DB_Type", "DB_Type in ('SQL Server', 'Postgres')");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_ProjectComment", b =>
                {
                    b.Property<int>("Comment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Comment_Date_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment_NT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Comment_ID");

                    b.HasIndex("Project_ID");

                    b.ToTable("Project_Comments");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_ProjectServiceRequests", b =>
                {
                    b.Property<int>("ServiceRequests_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Is_Completed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Notification_Sent")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ServiceRequests_Date_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("User_ID")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("User_Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ServiceRequests_ID");

                    b.HasIndex("Project_ID");

                    b.ToTable("Project_Requests");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project_Access_Request", b =>
                {
                    b.Property<int>("Request_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Completion_DT")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Databricks")
                        .HasColumnType("bit");

                    b.Property<bool>("PowerBI")
                        .HasColumnType("bit");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Request_DT")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("User_ID")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("WebForms")
                        .HasColumnType("bit");

                    b.HasKey("Request_ID");

                    b.HasIndex("Project_ID");

                    b.ToTable("Access_Requests");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project_Costs", b =>
                {
                    b.Property<int>("ProjectCosts_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost_AMT")
                        .HasColumnType("float");

                    b.Property<string>("Project_Acronym_CD")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Project_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_DT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Usage_DT")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectCosts_ID");

                    b.ToTable("Project_Costs");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project_Pipeline_Lnk", b =>
                {
                    b.Property<int>("Project_ID")
                        .HasColumnType("int");

                    b.Property<string>("Process_Nm")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Project_ID", "Process_Nm");

                    b.ToTable("Project_Pipeline_Links");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project_User", b =>
                {
                    b.Property<int>("ProjectUser_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApprovedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Approved_DT")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDataApprover")
                        .HasColumnType("bit");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("User_ID")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("User_Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ProjectUser_ID");

                    b.HasIndex("Project_ID");

                    b.ToTable("Project_Users");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project_User_Request", b =>
                {
                    b.Property<int>("ProjectUserRequest_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApprovedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Approved_DT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Requested_DT")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("User_ID")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ProjectUserRequest_ID");

                    b.HasIndex("Project_ID");

                    b.ToTable("Project_Users_Requests");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.PBI_License_Request", b =>
                {
                    b.Property<int>("Request_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact_Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Contact_Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Desktop_Usage_Flag")
                        .HasColumnType("bit");

                    b.Property<bool>("Premium_License_Flag")
                        .HasColumnType("bit");

                    b.Property<int>("Project_ID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("User_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Request_ID");

                    b.HasIndex("Project_ID")
                        .IsUnique();

                    b.ToTable("PowerBI_License_Requests");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.PBI_User_License_Request", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LicenseType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("RequestID")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.HasIndex("RequestID");

                    b.ToTable("PowerBI_License_User_Requests");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_Database", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Project_ID");

                    b.ToTable("Project_Databases");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_PBI_DataSet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DatasetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.Property<Guid>("Workspace")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Project_ID");

                    b.ToTable("Project_PBI_DataSets");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_PBI_Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.Property<string>("ReportName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Workspace")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Project_ID");

                    b.ToTable("Project_PBI_Reports");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_PBI_Workspace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Project_ID");

                    b.ToTable("Project_PBI_Workspaces");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_Resources", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attributes")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Project_ID")
                        .HasColumnType("int");

                    b.Property<string>("ResourceName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ResourceType")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeRequested")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Project_ID");

                    b.ToTable("Project_Resources");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_Storage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Datahub_ProjectProject_ID")
                        .HasColumnType("int");

                    b.Property<int>("Storage_Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Datahub_ProjectProject_ID");

                    b.ToTable("Project_Storage");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.PublicDataFile", b =>
                {
                    b.Property<long>("PublicDataFile_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ApprovedDate_DT")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("File_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Filename_TXT")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FolderPath_TXT")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("ProjectCode_CD")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("PublicationDate_DT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequestedDate_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestingUser_ID")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("SubmittedDate_DT")
                        .HasColumnType("datetime2");

                    b.HasKey("PublicDataFile_ID");

                    b.HasIndex("File_ID")
                        .IsUnique();

                    b.ToTable("PublicDataFiles");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.SharedDataFile", b =>
                {
                    b.Property<long>("SharedDataFile_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ApprovedDate_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ApprovingUser_ID")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("File_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Filename_TXT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FolderPath_TXT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOpenDataRequest_FLAG")
                        .HasColumnType("bit");

                    b.Property<string>("ProjectCode_CD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PublicationDate_DT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequestedDate_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestingUser_ID")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("SubmittedDate_DT")
                        .HasColumnType("datetime2");

                    b.HasKey("SharedDataFile_ID");

                    b.HasIndex("File_ID")
                        .IsUnique();

                    b.ToTable("SharedDataFiles");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.WebForm", b =>
                {
                    b.Property<int>("WebForm_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Project_ID")
                        .HasColumnType("int");

                    b.Property<string>("Title_DESC")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("WebForm_ID");

                    b.HasIndex("Project_ID");

                    b.ToTable("WebForms");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.WebForm_DBCodes", b =>
                {
                    b.Property<string>("DBCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ClassWord_DEF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassWord_DESC")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DBCode");

                    b.ToTable("DBCodes");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.WebForm_Field", b =>
                {
                    b.Property<int>("FieldID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_Updated_DT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension_CD")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)")
                        .HasDefaultValue("NONE");

                    b.Property<string>("Field_DESC")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Mandatory_FLAG")
                        .HasColumnType("bit");

                    b.Property<int?>("Max_Length_NUM")
                        .HasColumnType("int");

                    b.Property<string>("Notes_TXT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section_DESC")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type_CD")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)")
                        .HasDefaultValue("Text");

                    b.Property<int>("WebForm_ID")
                        .HasColumnType("int");

                    b.HasKey("FieldID");

                    b.HasIndex("WebForm_ID");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.OpenDataSharedFile", b =>
                {
                    b.HasBaseType("Datahub.Core.EFCore.SharedDataFile");

                    b.Property<int?>("ApprovalForm_ID")
                        .HasColumnType("int");

                    b.Property<string>("SignedApprovalForm_URL")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("OpenDataSharedFile");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_ProjectComment", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany("Comments")
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_ProjectServiceRequests", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany()
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project_Access_Request", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany("Requests")
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project_Pipeline_Lnk", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany("Pipelines")
                        .HasForeignKey("Project_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project_User", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany("Users")
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project_User_Request", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany()
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.PBI_License_Request", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithOne("PBI_License_Request")
                        .HasForeignKey("Datahub.Core.EFCore.PBI_License_Request", "Project_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.PBI_User_License_Request", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.PBI_License_Request", "LicenseRequest")
                        .WithMany("User_License_Requests")
                        .HasForeignKey("RequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LicenseRequest");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_Database", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany("Databases")
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_PBI_DataSet", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany("PBI_DataSets")
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_PBI_Report", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany("PBI_Reports")
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_PBI_Workspace", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany("PBI_Workspaces")
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_Resources", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany()
                        .HasForeignKey("Project_ID");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Project_Storage", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", null)
                        .WithMany("StorageAccounts")
                        .HasForeignKey("Datahub_ProjectProject_ID");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.WebForm", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.Datahub_Project", "Project")
                        .WithMany("WebForms")
                        .HasForeignKey("Project_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.WebForm_Field", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.WebForm", "WebForm")
                        .WithMany("Fields")
                        .HasForeignKey("WebForm_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WebForm");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.OpenDataSharedFile", b =>
                {
                    b.HasOne("Datahub.Core.EFCore.SharedDataFile", null)
                        .WithOne()
                        .HasForeignKey("Datahub.Core.EFCore.OpenDataSharedFile", "SharedDataFile_ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Datahub.Core.EFCore.Datahub_Project", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Databases");

                    b.Navigation("PBI_DataSets");

                    b.Navigation("PBI_License_Request");

                    b.Navigation("PBI_Reports");

                    b.Navigation("PBI_Workspaces");

                    b.Navigation("Pipelines");

                    b.Navigation("Requests");

                    b.Navigation("StorageAccounts");

                    b.Navigation("Users");

                    b.Navigation("WebForms");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.PBI_License_Request", b =>
                {
                    b.Navigation("User_License_Requests");
                });

            modelBuilder.Entity("Datahub.Core.EFCore.WebForm", b =>
                {
                    b.Navigation("Fields");
                });
#pragma warning restore 612, 618
        }
    }
}
