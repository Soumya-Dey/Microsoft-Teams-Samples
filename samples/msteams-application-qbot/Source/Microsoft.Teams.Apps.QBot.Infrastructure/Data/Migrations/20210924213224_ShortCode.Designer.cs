﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Teams.Apps.QBot.Infrastructure.Data;

namespace Microsoft.Teams.Apps.QBot.Infrastructure.Data.Migrations
{
    [DbContext(typeof(QBotDbContext))]
    [Migration("20210924213224_ShortCode")]
    partial class ShortCode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.AnswerEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AcceptedById")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChannelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("TimeStamp")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId")
                        .IsUnique();

                    b.ToTable("AnswerEntity");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.AppSettingEntity", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppSettings");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.ChannelEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("KnowledgeBaseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TeamAadObjectId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeamId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("KnowledgeBaseId");

                    b.HasIndex("TeamAadObjectId")
                        .IsUnique();

                    b.HasIndex("TeamId")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseMemberEntity", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MemberRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseMemberEntity");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.KnowledgeBaseEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerUserId");

                    b.ToTable("KnowledgeBases");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.QuestionEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AnswerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChannelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InitialResponseMessageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("TimeStamp")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.HasIndex("MessageId")
                        .IsUnique();

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.TutorialGroupEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ShortCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("TutorialGroups");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.TutorialGroupMemberEntity", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TutorialGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CourseId", "TutorialGroupId", "UserId");

                    b.HasIndex("TutorialGroupId");

                    b.HasIndex("UserId");

                    b.HasIndex("CourseId", "UserId");

                    b.ToTable("TutorialGroupMemberEntity");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.UserEntity", b =>
                {
                    b.Property<string>("AadId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Upn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AadId");

                    b.HasIndex("TeamId")
                        .IsUnique()
                        .HasFilter("[TeamId] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.AnswerEntity", b =>
                {
                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.QuestionEntity", "Question")
                        .WithOne("Answer")
                        .HasForeignKey("Microsoft.Teams.Apps.QBot.Infrastructure.Data.AnswerEntity", "QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.ChannelEntity", b =>
                {
                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseEntity", null)
                        .WithMany("Channels")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseEntity", b =>
                {
                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.KnowledgeBaseEntity", null)
                        .WithMany("Courses")
                        .HasForeignKey("KnowledgeBaseId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseMemberEntity", b =>
                {
                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseEntity", "Course")
                        .WithMany("Members")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.UserEntity", "User")
                        .WithMany("CourseMembership")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.KnowledgeBaseEntity", b =>
                {
                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.UserEntity", null)
                        .WithMany("KnowledgeBases")
                        .HasForeignKey("OwnerUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.QuestionEntity", b =>
                {
                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.ChannelEntity", null)
                        .WithMany("Questions")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.TutorialGroupEntity", b =>
                {
                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseEntity", null)
                        .WithMany("TutorialGroups")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.TutorialGroupMemberEntity", b =>
                {
                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.TutorialGroupEntity", "TutorialGroup")
                        .WithMany("Members")
                        .HasForeignKey("TutorialGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.UserEntity", "User")
                        .WithMany("TutorialGroupMembership")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseMemberEntity", null)
                        .WithMany("TutorialGroupsMembership")
                        .HasForeignKey("CourseId", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("TutorialGroup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.ChannelEntity", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseEntity", b =>
                {
                    b.Navigation("Channels");

                    b.Navigation("Members");

                    b.Navigation("TutorialGroups");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.CourseMemberEntity", b =>
                {
                    b.Navigation("TutorialGroupsMembership");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.KnowledgeBaseEntity", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.QuestionEntity", b =>
                {
                    b.Navigation("Answer");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.TutorialGroupEntity", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("Microsoft.Teams.Apps.QBot.Infrastructure.Data.UserEntity", b =>
                {
                    b.Navigation("CourseMembership");

                    b.Navigation("KnowledgeBases");

                    b.Navigation("TutorialGroupMembership");
                });
#pragma warning restore 612, 618
        }
    }
}