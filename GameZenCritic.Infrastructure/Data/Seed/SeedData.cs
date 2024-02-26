using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Seed
{
    internal class SeedData
    {
        public Publisher[] publishers { get; set; } = null!;
        public Player[] players { get; set; } = null!;

        public SeedData()
        {
            SeedPublishers();
            SeedPlayers();
        }

        private void SeedPublishers()
        {
            publishers = new Publisher[] 
            {
                new Publisher()
                {
                    Id = 1,
                    Name = "Microsoft Game Studios",
                },
                new Publisher()
                {
                    Id = 2,
                    Name = "Bandai Namco Games",
                },
                new Publisher()
                {
                    Id = 3,
                    Name = "Larian Studios Gamess",
                },
                new Publisher()
                {
                    Id = 4,
                    Name = "CD Projekt Red Studio",
                },
                new Publisher()
                {
                    Id = 5,
                    Name = "PlayStation Studios",
                },

            };
        }

        private void SeedPlayers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            Player TestPlayer1 = new Player()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395085",
                UserName = "player@mail.com",
                NormalizedUserName = "player@mail.com",
                Email = "player@mail.com",
                NormalizedEmail = "player@mail.com"
            };
            TestPlayer1.PasswordHash = hasher.HashPassword(TestPlayer1, "Test123456");

            Player TestPlayer2 = new Player()
            {
                Id = "fea12856-c198-4129-b3f3-b893d8395080",
                UserName = "player2@mail.com",
                NormalizedUserName = "player2@mail.com",
                Email = "player2@mail.com",
                NormalizedEmail = "player2@mail.com"
            };
            TestPlayer1.PasswordHash = hasher.HashPassword(TestPlayer2, "Test123456");

            players = new Player[] {TestPlayer1, TestPlayer2};
        }
    }
}
