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
        }
    }

}

