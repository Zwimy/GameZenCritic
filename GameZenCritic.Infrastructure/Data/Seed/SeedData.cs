using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Seed
{
    /// <summary>
    /// This is the seeding data for the database
    /// </summary>
    internal class SeedData
    {
        public Publisher[] publishers { get; set; } = null!;
        public Player[] players { get; set; } = null!;
        public Platform[] platforms { get; set; } = null!;
        public Genre[] genres { get; set; } = null!;
        public Developer[] developers { get; set; } = null!;
        public Game[] games { get; set; } = null!;
        public GamePlatform[] gamesPlatforms { get; set; } = null!;
        public GenreGame[] genresGames { get; set; } = null!;
        public News[] news { get; set; } = null!;
        public PlayerGameReview[] playersGamesReviews { get; set; } = null!;


        public SeedData()
        {
            SeedPublishers();
            SeedPlayers();
            SeedPlatforms();
            SeedGenres();
            SeedDevelopers();
            SeedGames();
            SeedGamesPlatforms();
            SeedGenresGames();
            SeedNews();
            SeedPlayersGamesReviews();
        }

        private void SeedPlayersGamesReviews()
        {
            playersGamesReviews = new PlayerGameReview[]
            {
                new PlayerGameReview
                {
                    GameId = Guid.Parse("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"),
                    PlayerId = "dea12856-c198-4129-b3f3-b893d8395085",
                    Details = "This is the greatest game ever made!",
                    Score = 10,
                },
                new PlayerGameReview
                {
                    GameId = Guid.Parse("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"),
                    PlayerId = "dea12856-c198-4129-b3f3-b893d8395085",
                    Details = "Was an OK shooter, but overhyped.",
                    Score = 7,
                },

            };
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

        private void SeedPlatforms()
        {
            platforms = new Platform[]
            {
                new Platform()
                {
                    Id = 1,
                    Name = "PC",
                },
                new Platform()
                {
                    Id = 2,
                    Name = "Xbox 360",
                },
                new Platform()
                {
                    Id = 3,
                    Name = "PlayStation 5",
                },
                new Platform()
                {
                    Id = 4,
                    Name = "Xbox Series X",
                },
                new Platform()
                {
                    Id = 5,
                    Name = "PlayStation 4",
                },
                new Platform()
                {
                    Id = 6,
                    Name = "Xbox One",
                },
                new Platform()
                {
                    Id = 7,
                    Name = "Nintendo Switch",
                }
            };
        }

        private void SeedGenres()
        {
            genres = new Genre[]
            {
                new Genre() 
                {
                    Id = 1,
                    Name = "Third Person Shooter"
                },
                new Genre() 
                {
                    Id = 2,
                    Name = "Action RPG"
                },
                new Genre() 
                {
                    Id = 3,
                    Name = "Western RPG"
                },
                new Genre() 
                {
                    Id = 4,
                    Name = "Action Adventure"
                },

            };
        }

        private void SeedDevelopers()
        {
            developers = new Developer[]
            {
                new Developer()
                {
                    Id= 1,
                    Name = "Epic Games"
                },
                new Developer()
                {
                    Id= 2,
                    Name = "From Software"
                },
                new Developer()
                {
                    Id= 3,
                    Name = "Larian Studios Games"
                },
                new Developer()
                {
                    Id= 4,
                    Name = "CD Projekt Red Studio"
                },
                new Developer()
                {
                    Id= 5,
                    Name = "SCE Santa Monica"
                },
            };
        }

        private void SeedGames()
        {
            games = new Game[]
            {
                new Game()
                {
                    Id = Guid.Parse("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"),
                    Name = "Gears of War",
                    Description = "Gears of War blends tactical action with survival horror and thrusts gamers into a deep and harrowing story of humankind's epic battle for survival against the Locust Horde, a nightmarish race of creatures that surface from the bowels of the planet.",
                    Picture = "https://www.metacritic.com/a/img/resize/c2c2122b8f2a30ff7dacbdf98d3091c0a9f8088c/catalog/provider/6/12/6-1-68349-52.jpg",
                    ReleaseDate = DateTime.ParseExact("NOV 7 - 2006", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 8m,
                    DeveloperId = 1,
                    PublisherId = 1,
                },
                new Game()
                {
                    Id = Guid.Parse("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"),
                    Name = "Elden Ring",
                    Description = "A New World Created By Hidetaka Miyazaki And George R. R. Martin ELDEN RING, developed by FromSoftware, Inc. and BANDAI NAMCO Entertainment Inc.",
                    Picture = "https://www.metacritic.com/a/img/resize/a7d9a5a01234b361785789476e073076a29dad5b/catalog/provider/6/3/6-1-824862-13.jpg",
                    ReleaseDate = DateTime.ParseExact("FEB 25 - 2022", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 9.5m,
                    DeveloperId = 2,
                    PublisherId = 2,
                },
                new Game()
                {
                    Id = Guid.Parse("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"),
                    Name = "Baldur's Gate 3",
                    Description = "An ancient evil has returned to Baldur's Gate, intent on devouring it from the inside out. The fate of Faerun lies in your hands. Alone, you may resist. But together, you can overcome.",
                    Picture = "https://www.metacritic.com/a/img/resize/04973a32611600dace99c3638bd3b8f6a9e09477/catalog/provider/7/2/7-1695438055.jpg",
                    ReleaseDate = DateTime.ParseExact("Aug 3 - 2023", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 9.3m,
                    DeveloperId = 3,
                    PublisherId = 3,
                },
                new Game()
                {
                    Id = Guid.Parse("3e33c5e3-ec4f-4b31-93b0-686fd2da6314"),
                    Name = "The Witcher 3: Wild Hunt",
                    Description = "With the Empire attacking the Kingdoms of the North and the Wild Hunt, a cavalcade of ghastly riders, breathing down your neck, the only way to survive is to fight back. As Geralt of Rivia, a master swordsman and monster hunter, leave none of your enemies standing.",
                    Picture = "https://pre00.deviantart.net/e81c/th/pre/f/2014/157/f/9/witcher_3_box_cover_warner_bros_variation_by_scratcherpen-d7l8i4h.png",
                    ReleaseDate = DateTime.ParseExact("MAY 19 - 2015", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 9.0m,
                    DeveloperId = 4,
                    PublisherId = 4,
                },
                new Game()
                {
                    Id = Guid.Parse("a8bf3a6e-509d-497b-92a7-f2c4d0f81b5b"),
                    Name = "God of War: Ragnarok",
                    Description = "The freezing winds of Fimbulwinter have come to Midgard, making survival for Kratos, Atreus, and Mimir in the Norse wilds even more challenging than before. ",
                    Picture = "https://www.metacritic.com/a/img/resize/ca0bc42afe883be3a8bac27a19cf2f972fb07921/catalog/provider/6/3/6-1-905093-13.jpg",
                    ReleaseDate = DateTime.ParseExact("NOV 9 - 2022", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 8.1m,
                    DeveloperId = 5,
                    PublisherId = 5,
                }
            };
        }

        private void SeedGamesPlatforms()
        {
            gamesPlatforms = new GamePlatform[]
            {
                new GamePlatform()
                {
                    GameId = Guid.Parse("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"),
                    PlatformId = 1
                },

                new GamePlatform()
                {
                    GameId = Guid.Parse("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"),
                    PlatformId = 2
                },

                new GamePlatform()
                {
                    GameId = Guid.Parse("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"),
                    PlatformId = 1
                },

                new GamePlatform()
                {
                    GameId = Guid.Parse("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"),
                    PlatformId = 3
                },

                new GamePlatform()
                {
                    GameId = Guid.Parse("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"),
                    PlatformId = 4
                },

                new GamePlatform()
                {
                    GameId = Guid.Parse("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"),
                    PlatformId = 1
                },

                new GamePlatform()
                {
                    GameId = Guid.Parse("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"),
                    PlatformId = 3
                },

                new GamePlatform()
                {
                    GameId = Guid.Parse("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"),
                    PlatformId = 4
                },


            };
        }

        private void SeedGenresGames()
        {
            genresGames = new GenreGame[]
            {
                new GenreGame()
                {
                    GameId = Guid.Parse("f0843ecf-38cf-4a72-a383-2b1c3c0d8d02"),
                    GenreId = 1
                },
                new GenreGame()
                {
                    GameId = Guid.Parse("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"),
                    GenreId = 2
                },
                new GenreGame()
                {
                    GameId = Guid.Parse("7f1e9d4b-53a8-4e63-9d23-31f48a11c41e"),
                    GenreId = 3
                },
                new GenreGame()
                {
                    GameId = Guid.Parse("3e33c5e3-ec4f-4b31-93b0-686fd2da6314"),
                    GenreId = 3
                },
                new GenreGame()
                {
                    GameId = Guid.Parse("a8bf3a6e-509d-497b-92a7-f2c4d0f81b5b"),
                    GenreId = 4
                },

            };
        }

        private void SeedNews()
        {
            news = new News[] 
            { 
                new News() 
                {
                    Id = Guid.Parse("aae47f27-2e4a-4e68-a4f2-0c5e3946b2ab"),
                    GameId = Guid.Parse("b16e5fc7-1fcd-48e8-ae77-6cf139b0b647"),
                    Title = "DLC incoming",
                    Description = "Elden Ring DLC is fast approaching and the new trailer has ignited a fierce online debate about Messmer The Impaler's origins. Messmer The Impaler is supposedly the big bad in the Shadow of the Erdtree expansion, as the Collector's Edition even dedicates a fully detailed figurine to the soon-to-be-boss. But the lore implications around Messmer have split the player base in two, between those who believe he was teased from the very beginning to those who think he's an entirely new creation made for the DLC. Messmer is the figure with several snakes peeking up out of his red robes. Pair that with the all-new landmark trees that are at the center of the new Land of Shadows map, coiled around each other chaotically, and the imagery is clear. Messmer is the Satan stand-in. He's the original sinner against the Erdtree. "
                }
            };
        }
    }
}
