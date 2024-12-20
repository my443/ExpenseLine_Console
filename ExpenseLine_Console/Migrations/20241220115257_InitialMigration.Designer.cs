﻿// <auto-generated />
using System;
using ExpenseLine_Console.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpenseLine_Console.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241220115257_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("ExpenseLine_Console.Models.Approval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApproverId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateApproved")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ExpenseId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ApproverId");

                    b.HasIndex("ExpenseId");

                    b.ToTable("Approvals");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DepartmentNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApprovalLimit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EE_ID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsProcessor")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExpenseStatusId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubmittedById")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(18, 2)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalHst")
                        .HasPrecision(18, 2)
                        .HasColumnType("TEXT");

                    b.Property<int>("VendorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseStatusId");

                    b.HasIndex("SubmittedById");

                    b.HasIndex("VendorId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.ExpenseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ExpenseId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Hst")
                        .HasPrecision(18, 2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ExpenseId");

                    b.ToTable("ExpenseDetails");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.ExpenseStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExpenseStatus");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.FileType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FileTypes");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.GLAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GLAccounts");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ExpenseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FileTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UploadTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("UploadedById")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseId");

                    b.HasIndex("FileTypeId");

                    b.HasIndex("UploadedById");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ApprovalId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ExpenseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NoteText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WrittenById")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ApprovalId");

                    b.HasIndex("ExpenseId");

                    b.HasIndex("WrittenById");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Approval", b =>
                {
                    b.HasOne("ExpenseLine_Console.Models.Employee", "Approver")
                        .WithMany()
                        .HasForeignKey("ApproverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseLine_Console.Models.Expense", null)
                        .WithMany("Approvals")
                        .HasForeignKey("ExpenseId");

                    b.Navigation("Approver");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Expense", b =>
                {
                    b.HasOne("ExpenseLine_Console.Models.ExpenseStatus", "ExpenseStatus")
                        .WithMany()
                        .HasForeignKey("ExpenseStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseLine_Console.Models.Employee", "SubmittedBy")
                        .WithMany()
                        .HasForeignKey("SubmittedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseLine_Console.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenseStatus");

                    b.Navigation("SubmittedBy");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.ExpenseDetail", b =>
                {
                    b.HasOne("ExpenseLine_Console.Models.GLAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseLine_Console.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseLine_Console.Models.Expense", null)
                        .WithMany("ExpenseDetails")
                        .HasForeignKey("ExpenseId");

                    b.Navigation("Account");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Image", b =>
                {
                    b.HasOne("ExpenseLine_Console.Models.Expense", null)
                        .WithMany("Images")
                        .HasForeignKey("ExpenseId");

                    b.HasOne("ExpenseLine_Console.Models.FileType", "FileType")
                        .WithMany()
                        .HasForeignKey("FileTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseLine_Console.Models.Employee", "UploadedBy")
                        .WithMany()
                        .HasForeignKey("UploadedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FileType");

                    b.Navigation("UploadedBy");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Note", b =>
                {
                    b.HasOne("ExpenseLine_Console.Models.Approval", null)
                        .WithMany("ApprovalComments")
                        .HasForeignKey("ApprovalId");

                    b.HasOne("ExpenseLine_Console.Models.Expense", null)
                        .WithMany("Notes")
                        .HasForeignKey("ExpenseId");

                    b.HasOne("ExpenseLine_Console.Models.Employee", "WrittenBy")
                        .WithMany()
                        .HasForeignKey("WrittenById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WrittenBy");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Approval", b =>
                {
                    b.Navigation("ApprovalComments");
                });

            modelBuilder.Entity("ExpenseLine_Console.Models.Expense", b =>
                {
                    b.Navigation("Approvals");

                    b.Navigation("ExpenseDetails");

                    b.Navigation("Images");

                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
