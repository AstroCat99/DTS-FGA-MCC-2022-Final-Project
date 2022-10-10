﻿// <auto-generated />
using System;
using LeaveManagementWebAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeaveManagementWebAPI.Migrations
{
    [DbContext(typeof(DBContext))]
<<<<<<<< HEAD:LeaveManagementWebAPI/Migrations/20221010145929_Initial.Designer.cs
    [Migration("20221010145929_Initial")]
========
    [Migration("20221010111214_Initial")]
>>>>>>>> fbc37ee (Added employee datatable.):LeaveManagementWebAPI/Migrations/20221010111214_Initial.Designer.cs
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeaveManagementWebAPI.Models.DepartmentType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("id");

                    b.ToTable("DepartmentTypes");
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("departmentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("genderTypeId")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("managerId")
                        .HasColumnType("int");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("id");

                    b.HasIndex("departmentTypeId");

                    b.HasIndex("genderTypeId");

                    b.HasIndex("managerId");

                    b.HasIndex("email", "phoneNumber")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.GenderType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("id");

                    b.ToTable("GenderTypes");
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.LeaveRequest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime");

                    b.Property<int>("leaveStatusTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("leaveTypeId")
                        .HasColumnType("int");

                    b.Property<string>("note")
                        .HasColumnType("text");

                    b.Property<string>("reason")
                        .HasColumnType("text");

                    b.Property<int>("requestedDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("leaveStatusTypeId");

                    b.HasIndex("leaveTypeId");

                    b.HasIndex("userId");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.LeaveStatusType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("id");

                    b.ToTable("LeaveStatusTypes");
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.LeaveType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("id");

                    b.ToTable("LeaveTypes");
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.User", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("availableLeaves")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(12);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("registeredAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("userRoleTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.HasKey("id");

                    b.HasIndex("userRoleTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.UserRoleType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("id");

                    b.ToTable("UserRoleTypes");
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.Employee", b =>
                {
                    b.HasOne("LeaveManagementWebAPI.Models.DepartmentType", "departmentType")
                        .WithMany()
                        .HasForeignKey("departmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeaveManagementWebAPI.Models.GenderType", "genderType")
                        .WithMany()
                        .HasForeignKey("genderTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeaveManagementWebAPI.Models.Employee", "manager")
                        .WithMany()
                        .HasForeignKey("managerId");
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.LeaveRequest", b =>
                {
                    b.HasOne("LeaveManagementWebAPI.Models.LeaveStatusType", "leaveStatusType")
                        .WithMany()
                        .HasForeignKey("leaveStatusTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeaveManagementWebAPI.Models.LeaveType", "leaveType")
                        .WithMany()
                        .HasForeignKey("leaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeaveManagementWebAPI.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LeaveManagementWebAPI.Models.User", b =>
                {
                    b.HasOne("LeaveManagementWebAPI.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeaveManagementWebAPI.Models.UserRoleType", "userRoleType")
                        .WithMany()
                        .HasForeignKey("userRoleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
