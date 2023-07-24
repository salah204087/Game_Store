using Game_StoreAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace Game_StoreAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<GameType> GameTypes { get; set; }
        public DbSet<GameCompany> GameCompanies { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GameType>().HasData(
                new GameType
                {
                    Id = 1,
                    Name = "Adventure game",
                    About = "An adventure game (rarely called quest game) is a video game genre in which the player assumes the role of a protagonist in an interactive story, driven by exploration and/or puzzle-solving.",
                    AddedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new GameType
                {
                    Id = 2,
                    Name = "Action",
                    About = "Action games emphasize physical challenges that require hand-eye coordination and motor skill to overcome. They center around the player, who is in control of most of the action. Most of the earliest video games were considered action games; today, it is still a vast genre covering all games that involve physical challenges.",
                    AddedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new GameType
                {
                    Id = 3,
                    Name = "Simulation video game",
                    About = "Simulation video games are a diverse super-category of video games, generally designed to closely simulate real world activities",
                    AddedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new GameType
                {
                    Id = 4,
                    Name = "Sports",
                    About = "A sports video game is a video game that simulates the practice of sports. Most sports have been recreated with a video games, including team sports, track and field, extreme sports, and combat sports.",
                    AddedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new GameType
                {
                    Id = 5,
                    Name = "Platform game",
                    About = "Platform games (or platformers) have gameplay primarily centered around jumping and climbing to navigate the player's environment. They may have enemies or obstacles to avoid and fight or may just be pure jumping puzzles.",
                    AddedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            );

            modelBuilder.Entity<GameCompany>().HasData(
                new GameCompany
                {
                    Id=1,
                    Name= "Nintendo",
                    Details= "Nintendo Co., Ltd.[b] is a Japanese multinational video game company headquartered in Kyoto. It develops, publishes and releases both video games and video game consoles.",
                    ImageUrl= "https://persiadigest.com/wp-content/uploads/2022/05/3-new-SNES-and-NES-games-are-now-available.jpg",
                    EstablishmentDate= "23 September 1889"
                },
                new GameCompany
                {
                    Id=2,
                    Name= "Ubisoft",
                    Details= "Ubisoft Entertainment SA (/ˈjuːbisɒft/; French: [ybisɔft];[5] formerly Ubi Soft Entertainment SA) is a French video game publisher headquartered in Saint-Mandé with development studios across the world. Its video game franchises include Assassin's Creed, Far Cry, For Honor, Just Dance, Prince of Persia, Rabbids, Rayman, Tom Clancy's, and Watch Dogs.",
                    ImageUrl= "https://cloudfront-us-east-2.images.arcpublishing.com/reuters/YSIZCJEAI5PDDLYHNZZCI5F2FI.jpg",
                    EstablishmentDate= "28 March 1986",
                },
                new GameCompany
                {
                    Id=3,
                    Name= "Electronic Arts",
                    Details= "Electronic Arts Inc. (EA) is an American video game company headquartered in Redwood City, California.",
                    ImageUrl= "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Electronic-Arts-Logo.svg/1200px-Electronic-Arts-Logo.svg.png",
                    EstablishmentDate= "27 May 1982"
                },
                new GameCompany
                {
                    Id=4,
                    Name= "Activision Blizzard",
                    Details= "Activision Blizzard, Inc.is an American video game holding company based in Santa Monica, California.",
                    ImageUrl= "https://www.videogameschronicle.com/files/2022/01/activision-blizzard-logo.jpg",
                    EstablishmentDate = "10 July 2008"
                },
                new GameCompany
                {
                    Id=5,
                    Name= "Epic Games",
                    Details= "Epic Games, Inc. is an American video game and software developer and publisher based in Cary, North Carolina. The company was founded by Tim Sweeney as Potomac Computer Systems in 1991, originally located in his parents' house in Potomac, Maryland.",
                    ImageUrl= "https://cdn2.unrealengine.com/epic-newsroom-share-1200x630-8c559c81a614.jpg",
                    EstablishmentDate= "1991"
                }
            );
            modelBuilder.Entity<Platform>().HasData(
                new Platform
                {
                    Id=1,
                    Name="PS4"
                },
                new Platform
                {
                    Id=2,
                    Name="PS5"
                },
                new Platform
                {
                    Id =3,
                    Name="PC"
                },
                new Platform
                {
                    Id=4,
                    Name= "Nintendo",
                },
                new Platform
                {
                    Id=5,
                    Name= "Xbox One S"
                },
                new Platform
                {
                    Id=6,
                    Name= "Xbox One X",
                },
                new Platform
                {
                    Id=7,
                    Name= "Xbox Series X"
                },
                new Platform
                {
                    Id=8,
                    Name= "Xbox Series S"
                }


            );
        }
    }

}

