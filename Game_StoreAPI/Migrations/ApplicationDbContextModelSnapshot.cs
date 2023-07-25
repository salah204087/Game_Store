﻿// <auto-generated />
using System;
using Game_StoreAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Game_StoreAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Game_StoreAPI.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("GameCompanyId")
                        .HasColumnType("int");

                    b.Property<int>("GameTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GameCompanyId");

                    b.HasIndex("GameTypeId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9486),
                            Description = "The game is played from either a third-person or first-person perspective, and its world is navigated on foot and by vehicle. Players control the three lead protagonists throughout single-player and switch among them, both during and outside missions.",
                            GameCompanyId = 4,
                            GameTypeId = 1,
                            ImageUrl = "https://c4.wallpaperflare.com/wallpaper/642/482/458/gun-skull-monkey-mask-rockstar-hd-wallpaper-preview.jpg",
                            Name = "Grand Theft Auto V",
                            Price = 70f,
                            Quantity = 6,
                            Rate = 4.5f,
                            UpdatedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9489)
                        },
                        new
                        {
                            Id = 2,
                            AddedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9493),
                            Description = "Call of Duty: Modern Warfare is a 2019 first-person shooter video game developed by Infinity Ward and published by Activision.",
                            GameCompanyId = 4,
                            GameTypeId = 2,
                            ImageUrl = "https://c4.wallpaperflare.com/wallpaper/790/727/718/face-mask-mask-military-armor-call-of-duty-hd-wallpaper-preview.jpg",
                            Name = "Call of Duty Modern Warfare",
                            Price = 60f,
                            Quantity = 10,
                            Rate = 4f,
                            UpdatedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9495)
                        },
                        new
                        {
                            Id = 3,
                            AddedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9497),
                            Description = "Assassin's Creed Origins is a 2017 action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.",
                            GameCompanyId = 2,
                            GameTypeId = 1,
                            ImageUrl = "https://c4.wallpaperflare.com/wallpaper/643/1018/529/4k-hieroglyphs-bayek-assassins-creed-origins-wallpaper-preview.jpg",
                            Name = "Assassin's Creed Origins",
                            Price = 50f,
                            Quantity = 6,
                            Rate = 5f,
                            UpdatedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9499)
                        },
                        new
                        {
                            Id = 4,
                            AddedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9501),
                            Description = "God of War is an action-adventure game franchise created by David Jaffe at Sony's Santa Monica Studio.",
                            GameCompanyId = 5,
                            GameTypeId = 1,
                            ImageUrl = "https://c4.wallpaperflare.com/wallpaper/280/925/183/kratos-god-of-war-4-god-of-war-2018-games-wallpaper-preview.jpg",
                            Name = "God of War",
                            Price = 90f,
                            Quantity = 5,
                            Rate = 4.5f,
                            UpdatedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9503)
                        });
                });

            modelBuilder.Entity("Game_StoreAPI.Models.GameCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstablishmentDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("GameCompanies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Details = "Nintendo Co., Ltd.[b] is a Japanese multinational video game company headquartered in Kyoto. It develops, publishes and releases both video games and video game consoles.",
                            EstablishmentDate = "23 September 1889",
                            ImageUrl = "https://persiadigest.com/wp-content/uploads/2022/05/3-new-SNES-and-NES-games-are-now-available.jpg",
                            Name = "Nintendo"
                        },
                        new
                        {
                            Id = 2,
                            Details = "Ubisoft Entertainment SA (/ˈjuːbisɒft/; French: [ybisɔft];[5] formerly Ubi Soft Entertainment SA) is a French video game publisher headquartered in Saint-Mandé with development studios across the world. Its video game franchises include Assassin's Creed, Far Cry, For Honor, Just Dance, Prince of Persia, Rabbids, Rayman, Tom Clancy's, and Watch Dogs.",
                            EstablishmentDate = "28 March 1986",
                            ImageUrl = "https://cloudfront-us-east-2.images.arcpublishing.com/reuters/YSIZCJEAI5PDDLYHNZZCI5F2FI.jpg",
                            Name = "Ubisoft"
                        },
                        new
                        {
                            Id = 3,
                            Details = "Electronic Arts Inc. (EA) is an American video game company headquartered in Redwood City, California.",
                            EstablishmentDate = "27 May 1982",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Electronic-Arts-Logo.svg/1200px-Electronic-Arts-Logo.svg.png",
                            Name = "Electronic Arts"
                        },
                        new
                        {
                            Id = 4,
                            Details = "Activision Blizzard, Inc.is an American video game holding company based in Santa Monica, California.",
                            EstablishmentDate = "10 July 2008",
                            ImageUrl = "https://www.videogameschronicle.com/files/2022/01/activision-blizzard-logo.jpg",
                            Name = "Activision Blizzard"
                        },
                        new
                        {
                            Id = 5,
                            Details = "Epic Games, Inc. is an American video game and software developer and publisher based in Cary, North Carolina. The company was founded by Tim Sweeney as Potomac Computer Systems in 1991, originally located in his parents' house in Potomac, Maryland.",
                            EstablishmentDate = "1991",
                            ImageUrl = "https://cdn2.unrealengine.com/epic-newsroom-share-1200x630-8c559c81a614.jpg",
                            Name = "Epic Games"
                        });
                });

            modelBuilder.Entity("Game_StoreAPI.Models.GamePlatform", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "PlatformId");

                    b.HasIndex("PlatformId");

                    b.ToTable("GamePlatform");
                });

            modelBuilder.Entity("Game_StoreAPI.Models.GameType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("GameTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "An adventure game (rarely called quest game) is a video game genre in which the player assumes the role of a protagonist in an interactive story, driven by exploration and/or puzzle-solving.",
                            AddedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9246),
                            Name = "Adventure game",
                            UpdatedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9297)
                        },
                        new
                        {
                            Id = 2,
                            About = "Action games emphasize physical challenges that require hand-eye coordination and motor skill to overcome. They center around the player, who is in control of most of the action. Most of the earliest video games were considered action games; today, it is still a vast genre covering all games that involve physical challenges.",
                            AddedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9300),
                            Name = "Action",
                            UpdatedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9301)
                        },
                        new
                        {
                            Id = 3,
                            About = "Simulation video games are a diverse super-category of video games, generally designed to closely simulate real world activities",
                            AddedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9303),
                            Name = "Simulation video game",
                            UpdatedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9304)
                        },
                        new
                        {
                            Id = 4,
                            About = "A sports video game is a video game that simulates the practice of sports. Most sports have been recreated with a video games, including team sports, track and field, extreme sports, and combat sports.",
                            AddedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9306),
                            Name = "Sports",
                            UpdatedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9308)
                        },
                        new
                        {
                            Id = 5,
                            About = "Platform games (or platformers) have gameplay primarily centered around jumping and climbing to navigate the player's environment. They may have enemies or obstacles to avoid and fight or may just be pure jumping puzzles.",
                            AddedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9309),
                            Name = "Platform game",
                            UpdatedDate = new DateTime(2023, 7, 25, 18, 38, 37, 100, DateTimeKind.Local).AddTicks(9311)
                        });
                });

            modelBuilder.Entity("Game_StoreAPI.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "PS4"
                        },
                        new
                        {
                            Id = 2,
                            Name = "PS5"
                        },
                        new
                        {
                            Id = 3,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Nintendo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Xbox One S"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Xbox One X"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Xbox Series X"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Xbox Series S"
                        });
                });

            modelBuilder.Entity("Game_StoreAPI.Models.Game", b =>
                {
                    b.HasOne("Game_StoreAPI.Models.GameCompany", "GameCompany")
                        .WithMany()
                        .HasForeignKey("GameCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Game_StoreAPI.Models.GameType", "GameType")
                        .WithMany()
                        .HasForeignKey("GameTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameCompany");

                    b.Navigation("GameType");
                });

            modelBuilder.Entity("Game_StoreAPI.Models.GamePlatform", b =>
                {
                    b.HasOne("Game_StoreAPI.Models.Game", "Game")
                        .WithMany("GamePlatform")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Game_StoreAPI.Models.Platform", "Platform")
                        .WithMany("GamePlatform")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("Game_StoreAPI.Models.Game", b =>
                {
                    b.Navigation("GamePlatform");
                });

            modelBuilder.Entity("Game_StoreAPI.Models.Platform", b =>
                {
                    b.Navigation("GamePlatform");
                });
#pragma warning restore 612, 618
        }
    }
}
