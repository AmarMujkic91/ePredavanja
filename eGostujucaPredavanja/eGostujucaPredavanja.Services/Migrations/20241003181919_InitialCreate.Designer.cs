﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eGostujucaPredavanja.Services.Database;

#nullable disable

namespace eGostujucaPredavanja.Services.Migrations
{
    [DbContext(typeof(eGostujucaPredavanjaContext))]
    [Migration("20241003181919_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.EventSponsors", b =>
                {
                    b.Property<int>("EventSponsorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventSponsorId"));

                    b.Property<string>("BootNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("EventsEventId")
                        .HasColumnType("int");

                    b.Property<int>("SponsorsSponsorId")
                        .HasColumnType("int");

                    b.Property<int>("SponzorId")
                        .HasColumnType("int");

                    b.HasKey("EventSponsorId");

                    b.HasIndex("EventsEventId");

                    b.HasIndex("SponsorsSponsorId");

                    b.ToTable("EventSponsors");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.EventTypes", b =>
                {
                    b.Property<int>("EventTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventTypeId");

                    b.ToTable("EventTypes");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Events", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventTypeId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.HasIndex("EventTypeId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.JobAppliations", b =>
                {
                    b.Property<int>("JobAppliationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobAppliationId"));

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("EventsEventId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("JobsJobId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobAppliationId");

                    b.HasIndex("EventsEventId");

                    b.HasIndex("JobsJobId");

                    b.ToTable("JobAppliations");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Jobs", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"));

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventsEventId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsId");

                    b.HasIndex("EventsEventId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Positions", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.SessionSpeakers", b =>
                {
                    b.Property<int>("SessionSpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SessionSpeakerId"));

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<int>("SessionsSessionId")
                        .HasColumnType("int");

                    b.Property<int>("SpeakerId")
                        .HasColumnType("int");

                    b.Property<int>("SpeakersSpeakerId")
                        .HasColumnType("int");

                    b.HasKey("SessionSpeakerId");

                    b.HasIndex("SessionsSessionId");

                    b.HasIndex("SpeakersSpeakerId");

                    b.ToTable("SessionSpeakers");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Sessions", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SessionId"));

                    b.Property<string>("Building")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int?>("EventsEventId")
                        .HasColumnType("int");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SessionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SessionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SessionId");

                    b.HasIndex("EventsEventId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Speakers", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpeakerId"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organisation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpeakerId");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Sponsors", b =>
                {
                    b.Property<int>("SponsorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SponsorId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganisationEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganisationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SponsorId");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.UserEvents", b =>
                {
                    b.Property<int>("UserEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserEventId"));

                    b.Property<byte>("CheckedIn")
                        .HasColumnType("tinyint");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("EventsEventId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("UserEventId");

                    b.HasIndex("EventsEventId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("UserEvents");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.UserPositions", b =>
                {
                    b.Property<int>("UserPositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPositionId"));

                    b.Property<DateTime>("DateOfChanges")
                        .HasColumnType("datetime2");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("PositionsPositionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("UserPositionId");

                    b.HasIndex("PositionsPositionId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("UserPositions");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.UserSessions", b =>
                {
                    b.Property<int>("UserSessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserSessionId"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserSessionId");

                    b.HasIndex("SessionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSessions");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Addres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.EventSponsors", b =>
                {
                    b.HasOne("eGostujucaPredavanja.Services.Database.Events", "Events")
                        .WithMany("EventSponsors")
                        .HasForeignKey("EventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGostujucaPredavanja.Services.Database.Sponsors", "Sponsors")
                        .WithMany("EventSponsors")
                        .HasForeignKey("SponsorsSponsorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Events");

                    b.Navigation("Sponsors");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Events", b =>
                {
                    b.HasOne("eGostujucaPredavanja.Services.Database.EventTypes", "EventType")
                        .WithMany("Events")
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.JobAppliations", b =>
                {
                    b.HasOne("eGostujucaPredavanja.Services.Database.Events", "Events")
                        .WithMany("JobAppliations")
                        .HasForeignKey("EventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGostujucaPredavanja.Services.Database.Jobs", "Jobs")
                        .WithMany("JobAppliations")
                        .HasForeignKey("JobsJobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Events");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.News", b =>
                {
                    b.HasOne("eGostujucaPredavanja.Services.Database.Events", "Events")
                        .WithMany("News")
                        .HasForeignKey("EventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Events");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.SessionSpeakers", b =>
                {
                    b.HasOne("eGostujucaPredavanja.Services.Database.Sessions", "Sessions")
                        .WithMany("SessionSpeakers")
                        .HasForeignKey("SessionsSessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGostujucaPredavanja.Services.Database.Speakers", "Speakers")
                        .WithMany("SessionSpeakers")
                        .HasForeignKey("SpeakersSpeakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sessions");

                    b.Navigation("Speakers");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Sessions", b =>
                {
                    b.HasOne("eGostujucaPredavanja.Services.Database.Events", null)
                        .WithMany("Sessions")
                        .HasForeignKey("EventsEventId");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.UserEvents", b =>
                {
                    b.HasOne("eGostujucaPredavanja.Services.Database.Events", "Events")
                        .WithMany("UserEvents")
                        .HasForeignKey("EventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGostujucaPredavanja.Services.Database.Users", "Users")
                        .WithMany("UserEvents")
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Events");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.UserPositions", b =>
                {
                    b.HasOne("eGostujucaPredavanja.Services.Database.Positions", "Positions")
                        .WithMany("UserPositions")
                        .HasForeignKey("PositionsPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGostujucaPredavanja.Services.Database.Users", "Users")
                        .WithMany("UserPositions")
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Positions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.UserSessions", b =>
                {
                    b.HasOne("eGostujucaPredavanja.Services.Database.Sessions", "Session")
                        .WithMany("UserSessions")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGostujucaPredavanja.Services.Database.Users", "User")
                        .WithMany("UserSessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.EventTypes", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Events", b =>
                {
                    b.Navigation("EventSponsors");

                    b.Navigation("JobAppliations");

                    b.Navigation("News");

                    b.Navigation("Sessions");

                    b.Navigation("UserEvents");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Jobs", b =>
                {
                    b.Navigation("JobAppliations");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Positions", b =>
                {
                    b.Navigation("UserPositions");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Sessions", b =>
                {
                    b.Navigation("SessionSpeakers");

                    b.Navigation("UserSessions");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Speakers", b =>
                {
                    b.Navigation("SessionSpeakers");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Sponsors", b =>
                {
                    b.Navigation("EventSponsors");
                });

            modelBuilder.Entity("eGostujucaPredavanja.Services.Database.Users", b =>
                {
                    b.Navigation("UserEvents");

                    b.Navigation("UserPositions");

                    b.Navigation("UserSessions");
                });
#pragma warning restore 612, 618
        }
    }
}
