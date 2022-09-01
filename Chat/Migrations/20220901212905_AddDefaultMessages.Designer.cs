﻿// <auto-generated />
using System;
using Chat.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Chat.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220901212905_AddDefaultMessages")]
    partial class AddDefaultMessages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Chat.Models.DboModels.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"),
                            Created = new DateTime(2022, 9, 1, 17, 47, 50, 0, DateTimeKind.Unspecified),
                            GroupName = "TestGroup1"
                        },
                        new
                        {
                            Id = new Guid("56775ee9-6735-485e-9283-c9ab65831c64"),
                            Created = new DateTime(2022, 9, 1, 17, 48, 50, 0, DateTimeKind.Unspecified),
                            GroupName = "TestGroup2"
                        });
                });

            modelBuilder.Entity("Chat.Models.DboModels.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<Guid>("FromUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVisibleForOwner")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ReplyMessageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ToUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ReplyMessageId");

                    b.HasIndex("ToUserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f822d7d-dd51-40be-af82-115916947844"),
                            Created = new DateTime(2022, 9, 1, 17, 55, 50, 0, DateTimeKind.Unspecified),
                            FromUserId = new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230"),
                            IsVisible = true,
                            IsVisibleForOwner = true,
                            Text = "Hello",
                            ToUserId = new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15")
                        },
                        new
                        {
                            Id = new Guid("5d045d62-5364-4aa1-b12a-2eab889d6a77"),
                            Created = new DateTime(2022, 9, 1, 17, 56, 50, 0, DateTimeKind.Unspecified),
                            FromUserId = new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15"),
                            IsVisible = true,
                            IsVisibleForOwner = true,
                            Text = "Hi",
                            ToUserId = new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230")
                        },
                        new
                        {
                            Id = new Guid("7f00d977-9b3a-4780-896d-1fb4d3d6ecae"),
                            Created = new DateTime(2022, 9, 1, 17, 57, 50, 0, DateTimeKind.Unspecified),
                            FromUserId = new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230"),
                            IsVisible = true,
                            IsVisibleForOwner = true,
                            ReplyMessageId = new Guid("5d045d62-5364-4aa1-b12a-2eab889d6a77"),
                            Text = "How are you?",
                            ToUserId = new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15")
                        },
                        new
                        {
                            Id = new Guid("d59b98a3-2fc7-48af-a483-07b6f0d45c6c"),
                            Created = new DateTime(2022, 9, 1, 17, 56, 50, 0, DateTimeKind.Unspecified),
                            FromUserId = new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15"),
                            GroupId = new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"),
                            IsVisible = true,
                            IsVisibleForOwner = true,
                            Text = "Lol"
                        },
                        new
                        {
                            Id = new Guid("315a053f-f19a-4a5d-9022-e6190400c006"),
                            Created = new DateTime(2022, 9, 1, 17, 57, 50, 0, DateTimeKind.Unspecified),
                            FromUserId = new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230"),
                            GroupId = new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"),
                            IsVisible = true,
                            IsVisibleForOwner = true,
                            Text = "Kek"
                        });
                });

            modelBuilder.Entity("Chat.Models.DboModels.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230"),
                            Created = new DateTime(2022, 9, 1, 17, 45, 50, 0, DateTimeKind.Unspecified),
                            UserName = "olka"
                        },
                        new
                        {
                            Id = new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15"),
                            Created = new DateTime(2022, 9, 1, 17, 46, 50, 0, DateTimeKind.Unspecified),
                            UserName = "test"
                        });
                });

            modelBuilder.Entity("GroupUser", b =>
                {
                    b.Property<Guid>("GroupsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GroupsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("UserGroupsRelationship", (string)null);

                    b.HasData(
                        new
                        {
                            GroupsId = new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"),
                            UsersId = new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230")
                        },
                        new
                        {
                            GroupsId = new Guid("56775ee9-6735-485e-9283-c9ab65831c64"),
                            UsersId = new Guid("7aaab85f-fd13-4ea3-bda6-6397100ae230")
                        },
                        new
                        {
                            GroupsId = new Guid("33e26927-34e7-412b-9d11-b0f93a533bb6"),
                            UsersId = new Guid("d0845b19-dd1f-4459-9890-47e341e5fd15")
                        });
                });

            modelBuilder.Entity("Chat.Models.DboModels.Message", b =>
                {
                    b.HasOne("Chat.Models.DboModels.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chat.Models.DboModels.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("Chat.Models.DboModels.Message", "ReplyMessage")
                        .WithMany()
                        .HasForeignKey("ReplyMessageId");

                    b.HasOne("Chat.Models.DboModels.User", "ToUser")
                        .WithMany()
                        .HasForeignKey("ToUserId");

                    b.Navigation("FromUser");

                    b.Navigation("Group");

                    b.Navigation("ReplyMessage");

                    b.Navigation("ToUser");
                });

            modelBuilder.Entity("GroupUser", b =>
                {
                    b.HasOne("Chat.Models.DboModels.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chat.Models.DboModels.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
