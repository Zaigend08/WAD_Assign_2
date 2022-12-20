﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WADProject.Models;

#nullable disable

namespace WADProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WADProject.Models.BloodCollectionModel", b =>
                {
                    b.Property<int>("BloodColId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BloodColId"), 1L, 1);

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<string>("Hospital")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("bldType")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<DateTime>("dateOfCollection")
                        .HasColumnType("datetime2");

                    b.Property<string>("noOfBags")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.HasKey("BloodColId");

                    b.HasIndex("DonorId");

                    b.ToTable("bloodCollectData");
                });

            modelBuilder.Entity("WADProject.Models.BloodIssuedModel", b =>
                {
                    b.Property<int>("BloodIsudId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BloodIsudId"), 1L, 1);

                    b.Property<int?>("amountPaid")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("controlNoBloodReqId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfIssuance")
                        .HasColumnType("datetime2");

                    b.Property<string>("issuedBY")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("issuedTo")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("BloodIsudId");

                    b.HasIndex("controlNoBloodReqId");

                    b.ToTable("bloodIssuedData");
                });

            modelBuilder.Entity("WADProject.Models.BloodRequestModel", b =>
                {
                    b.Property<int>("BloodReqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BloodReqId"), 1L, 1);

                    b.Property<int?>("Amount")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("varchar(4)");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("RecipientId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("controlNo")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("noOfBags")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<string>("requestedBy")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("BloodReqId");

                    b.HasIndex("RecipientId");

                    b.ToTable("bloodReqData");
                });

            modelBuilder.Entity("WADProject.Models.DonorModel", b =>
                {
                    b.Property<int>("DonorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonorId"), 1L, 1);

                    b.Property<string>("Donor")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("dAddress")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("dAge")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("dBloodType")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<int?>("dContact")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("dEmail")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("dGender")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("dRemarks")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("DonorId");

                    b.ToTable("DonorData");
                });

            modelBuilder.Entity("WADProject.Models.logsModel", b =>
                {
                    b.Property<int>("logId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("logId"), 1L, 1);

                    b.Property<int>("AccNameAccId")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("loginTime")
                        .IsRequired()
                        .HasColumnType("varchar(9)");

                    b.Property<string>("logoutTime")
                        .IsRequired()
                        .HasColumnType("varchar(9)");

                    b.HasKey("logId");

                    b.HasIndex("AccNameAccId");

                    b.ToTable("logsData");
                });

            modelBuilder.Entity("WADProject.Models.RecipientModel", b =>
                {
                    b.Property<int>("RecipientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipientId"), 1L, 1);

                    b.Property<string>("Recipient")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("rAddress")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("rAge")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("rBloodType")
                        .IsRequired()
                        .HasColumnType("varchar(4)");

                    b.Property<int?>("rContact")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("rEmail")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("rGender")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<string>("rRemarks")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("RecipientId");

                    b.ToTable("RecipientData");
                });

            modelBuilder.Entity("WADProject.Models.userAccountsModel", b =>
                {
                    b.Property<int>("AccId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccId"), 1L, 1);

                    b.Property<string>("AccName")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.HasKey("AccId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("WADProject.Models.BloodCollectionModel", b =>
                {
                    b.HasOne("WADProject.Models.DonorModel", "donor")
                        .WithMany()
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("donor");
                });

            modelBuilder.Entity("WADProject.Models.BloodIssuedModel", b =>
                {
                    b.HasOne("WADProject.Models.BloodRequestModel", "controlNo")
                        .WithMany()
                        .HasForeignKey("controlNoBloodReqId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("controlNo");
                });

            modelBuilder.Entity("WADProject.Models.BloodRequestModel", b =>
                {
                    b.HasOne("WADProject.Models.RecipientModel", "Recipient")
                        .WithMany()
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipient");
                });

            modelBuilder.Entity("WADProject.Models.logsModel", b =>
                {
                    b.HasOne("WADProject.Models.userAccountsModel", "AccName")
                        .WithMany()
                        .HasForeignKey("AccNameAccId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccName");
                });
#pragma warning restore 612, 618
        }
    }
}
