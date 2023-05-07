﻿// <auto-generated />
using System;
using BlazorDay2Task;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorDay2Task.Migrations
{
    [DbContext(typeof(Task2Context))]
    [Migration("20230427141902_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharedLibrary.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrackId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrackId");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            TrackId = 1,
                            Description = "SD Track",
                            Name = "SD"
                        },
                        new
                        {
                            TrackId = 2,
                            Description = "LD Track",
                            Name = "LD"
                        },
                        new
                        {
                            TrackId = 3,
                            Description = "MD Track",
                            Name = "MD"
                        },
                        new
                        {
                            TrackId = 4,
                            Description = "HD Track",
                            Name = "HD"
                        },
                        new
                        {
                            TrackId = 5,
                            Description = "4K Track",
                            Name = "4K"
                        },
                        new
                        {
                            TrackId = 6,
                            Description = "8K Track",
                            Name = "8K"
                        },
                        new
                        {
                            TrackId = 7,
                            Description = "MP3 Track",
                            Name = "MP3"
                        },
                        new
                        {
                            TrackId = 8,
                            Description = "FLAC Track",
                            Name = "FLAC"
                        },
                        new
                        {
                            TrackId = 9,
                            Description = "WAV Track",
                            Name = "WAV"
                        },
                        new
                        {
                            TrackId = 10,
                            Description = "AAC Track",
                            Name = "AAC"
                        },
                        new
                        {
                            TrackId = 11,
                            Description = "AC3 Track",
                            Name = "AC3"
                        },
                        new
                        {
                            TrackId = 12,
                            Description = "DTS Track",
                            Name = "DTS"
                        },
                        new
                        {
                            TrackId = 13,
                            Description = "PCM Track",
                            Name = "PCM"
                        },
                        new
                        {
                            TrackId = 14,
                            Description = "AVI Track",
                            Name = "AVI"
                        },
                        new
                        {
                            TrackId = 15,
                            Description = "MKV Track",
                            Name = "MKV"
                        },
                        new
                        {
                            TrackId = 16,
                            Description = "MP4 Track",
                            Name = "MP4"
                        },
                        new
                        {
                            TrackId = 17,
                            Description = "FLV Track",
                            Name = "FLV"
                        },
                        new
                        {
                            TrackId = 18,
                            Description = "WMV Track",
                            Name = "WMV"
                        },
                        new
                        {
                            TrackId = 19,
                            Description = "MOV Track",
                            Name = "MOV"
                        },
                        new
                        {
                            TrackId = 20,
                            Description = "MPEG Track",
                            Name = "MPEG"
                        });
                });

            modelBuilder.Entity("SharedLibrary.Trainee", b =>
                {
                    b.Property<int>("TraineeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraineeId"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsGraduated")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("TraineeId");

                    b.HasIndex("TrackId");

                    b.ToTable("Trainees");

                    b.HasData(
                        new
                        {
                            TraineeId = 1,
                            Birthdate = new DateTime(2015, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmed@gmail.com",
                            Gender = 0,
                            IsGraduated = true,
                            MobileNo = "01093959322",
                            Name = "ahmed",
                            TrackId = 1
                        },
                        new
                        {
                            TraineeId = 2,
                            Birthdate = new DateTime(2014, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sara@gmail.com",
                            Gender = 1,
                            IsGraduated = false,
                            MobileNo = "0123456789",
                            Name = "Sara",
                            TrackId = 2
                        },
                        new
                        {
                            TraineeId = 3,
                            Birthdate = new DateTime(2013, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ali@gmail.com",
                            Gender = 0,
                            IsGraduated = false,
                            MobileNo = "0111222333",
                            Name = "Ali",
                            TrackId = 3
                        },
                        new
                        {
                            TraineeId = 4,
                            Birthdate = new DateTime(2012, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fatma@gmail.com",
                            Gender = 1,
                            IsGraduated = true,
                            MobileNo = "0101122334",
                            Name = "Fatma",
                            TrackId = 1
                        },
                        new
                        {
                            TraineeId = 5,
                            Birthdate = new DateTime(2011, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "omar@gmail.com",
                            Gender = 0,
                            IsGraduated = false,
                            MobileNo = "0123456789",
                            Name = "Omar",
                            TrackId = 4
                        },
                        new
                        {
                            TraineeId = 6,
                            Birthdate = new DateTime(2010, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mona@gmail.com",
                            Gender = 1,
                            IsGraduated = true,
                            MobileNo = "0109876543",
                            Name = "Mona",
                            TrackId = 5
                        },
                        new
                        {
                            TraineeId = 7,
                            Birthdate = new DateTime(2009, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "khaled@gmail.com",
                            Gender = 0,
                            IsGraduated = false,
                            MobileNo = "0112233445",
                            Name = "Khaled",
                            TrackId = 6
                        },
                        new
                        {
                            TraineeId = 8,
                            Birthdate = new DateTime(2008, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nadia@gmail.com",
                            Gender = 1,
                            IsGraduated = false,
                            MobileNo = "0102233445",
                            Name = "Nadia",
                            TrackId = 7
                        },
                        new
                        {
                            TraineeId = 9,
                            Birthdate = new DateTime(2007, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hazem@gmail.com",
                            Gender = 0,
                            IsGraduated = true,
                            MobileNo = "0123456789",
                            Name = "Hazem",
                            TrackId = 2
                        },
                        new
                        {
                            TraineeId = 10,
                            Birthdate = new DateTime(2006, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "dina@gmail.com",
                            Gender = 1,
                            IsGraduated = false,
                            MobileNo = "0111122334",
                            Name = "Dina",
                            TrackId = 8
                        },
                        new
                        {
                            TraineeId = 11,
                            Birthdate = new DateTime(2005, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "youssef@gmail.com",
                            Gender = 0,
                            IsGraduated = true,
                            MobileNo = "0109998887",
                            Name = "Youssef",
                            TrackId = 9
                        },
                        new
                        {
                            TraineeId = 12,
                            Birthdate = new DateTime(2004, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nour@gmail.com",
                            Gender = 1,
                            IsGraduated = false,
                            MobileNo = "0101122334",
                            Name = "Nour",
                            TrackId = 10
                        },
                        new
                        {
                            TraineeId = 13,
                            Birthdate = new DateTime(2003, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hamza@gmail.com",
                            Gender = 0,
                            IsGraduated = false,
                            MobileNo = "0123456789",
                            Name = "Hamza",
                            TrackId = 11
                        },
                        new
                        {
                            TraineeId = 14,
                            Birthdate = new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "salma@gmail.com",
                            Gender = 1,
                            IsGraduated = true,
                            MobileNo = "0111222333",
                            Name = "Salma",
                            TrackId = 12
                        },
                        new
                        {
                            TraineeId = 15,
                            Birthdate = new DateTime(2001, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mohamed@gmail.com",
                            Gender = 0,
                            IsGraduated = false,
                            MobileNo = "01093959322",
                            Name = "Mohamed",
                            TrackId = 13
                        },
                        new
                        {
                            TraineeId = 16,
                            Birthdate = new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sara@gmail.com",
                            Gender = 1,
                            IsGraduated = true,
                            MobileNo = "0123456789",
                            Name = "Sara",
                            TrackId = 14
                        },
                        new
                        {
                            TraineeId = 17,
                            Birthdate = new DateTime(1999, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmed@gmail.com",
                            Gender = 0,
                            IsGraduated = false,
                            MobileNo = "0102233445",
                            Name = "Ahmed",
                            TrackId = 15
                        },
                        new
                        {
                            TraineeId = 18,
                            Birthdate = new DateTime(1998, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "yasmine@gmail.com",
                            Gender = 1,
                            IsGraduated = false,
                            MobileNo = "0112233445",
                            Name = "Yasmine",
                            TrackId = 16
                        },
                        new
                        {
                            TraineeId = 19,
                            Birthdate = new DateTime(1997, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hassan@gmail.com",
                            Gender = 0,
                            IsGraduated = true,
                            MobileNo = "0101122334",
                            Name = "Hassan",
                            TrackId = 17
                        },
                        new
                        {
                            TraineeId = 20,
                            Birthdate = new DateTime(1996, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "dalia@gmail.com",
                            Gender = 1,
                            IsGraduated = false,
                            MobileNo = "0123456789",
                            Name = "Dalia",
                            TrackId = 18
                        });
                });

            modelBuilder.Entity("SharedLibrary.Trainee", b =>
                {
                    b.HasOne("SharedLibrary.Track", "track")
                        .WithMany("Trainees")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("track");
                });

            modelBuilder.Entity("SharedLibrary.Track", b =>
                {
                    b.Navigation("Trainees");
                });
#pragma warning restore 612, 618
        }
    }
}