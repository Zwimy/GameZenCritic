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
        public News[] news { get; set; } = null!;
        public PlayerGameReview[] playersGamesReviews { get; set; } = null!;
        public Review[] reviews { get; set; } = null!;


        public SeedData()
        {
            SeedPublishers();
            SeedPlayers();
            SeedPlatforms();
            SeedGenres();
            SeedDevelopers();
            SeedGames();
            SeedGamesPlatforms();
            SeedReviews();
            SeedNews();
            SeedPlayersGamesReviews();
        }

        private void SeedReviews()
        {
            reviews = new Review[]
            {
                new Review()
                {
                    Id = 1,
                    Details = "This is the greatest game ever made!",
                    Score = 10,
                    PublishDate = DateTime.Now,
                },
                new Review()
                {
                    Id = 2,
                    Details = "Was an OK shooter, but overhyped.",
                    Score = 7,
                    PublishDate = DateTime.Now,
                }
            };
        }

        private void SeedPlayersGamesReviews()
        {
            playersGamesReviews = new PlayerGameReview[]
            {
                new PlayerGameReview
                {
                    ReviewId = 1,
                    GameId = 2,
                    PlayerId = "dea12856-c198-4129-b3f3-b893d8395085"
                    
                },
                new PlayerGameReview
                {
                    ReviewId = 2,
                    GameId = 1,
                    PlayerId = "dea12856-c198-4129-b3f3-b893d8395085"
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
                    CountryLocation = "USA"
                },
                new Publisher()
                {
                    Id = 2,
                    Name = "Bandai Namco Games",
                    CountryLocation = "Japan"
                },
                new Publisher()
                {
                    Id = 3,
                    Name = "Larian Studios Gamess",
                    CountryLocation = "Netherlands"
                },
                new Publisher()
                {
                    Id = 4,
                    Name = "CD Projekt Red Studio",
                    CountryLocation = "Poland"
                },
                new Publisher()
                {
                    Id = 5,
                    Name = "PlayStation Studios",
                    CountryLocation = "USA"
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
            TestPlayer2.PasswordHash = hasher.HashPassword(TestPlayer2, "Test123456");

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
                    Name = "Epic Games",
                    LogoLink = "https://logodownload.org/wp-content/uploads/2020/10/epic-games-logo-0.png",
                    GameRep = 6
                    
                },
                new Developer()
                {
                    Id= 2,
                    Name = "From Software",
                    LogoLink = "https://gamingbolt.com/wp-content/uploads/2019/12/FromSoftware-logo.jpg",
                    GameRep = 6

                },
                new Developer()
                {
                    Id= 3,
                    Name = "Larian Studios Games",
                    LogoLink = "https://www.gematsu.com/wp-content/uploads/2022/11/Company-Logo_Larian-Studios-320x456.png",
                    GameRep = 8
                },
                new Developer()
                {
                    Id= 4,
                    Name = "CD Projekt Red Studio",
                    LogoLink = "https://www.kitguru.net/wp-content/uploads/2016/03/cd-projekt-red-logo.png",
                    GameRep = 7
                },
                new Developer()
                {
                    Id= 5,
                    Name = "SCE Santa Monica",
                    LogoLink = "https://i.pinimg.com/564x/1e/5f/3d/1e5f3df1ca42e4719c459ac0792c6d53.jpg",
                    GameRep = 7
                },
            };
        }

        private void SeedGames()
        {
            games = new Game[]
            {
                new Game()
                {
                    Id = 1,
                    Name = "Gears of War",
                    Description = "Gears of War blends tactical action with survival horror and thrusts gamers into a deep and harrowing story of humankind's epic battle for survival against the Locust Horde, a nightmarish race of creatures that surface from the bowels of the planet.",
                    Picture = "https://twinfinite.net/wp-content/uploads/2023/01/Best-Xbox-360-Co-Op-Games.png?resize=1000%2C600",
                    ReleaseDate = DateTime.ParseExact("NOV 7 - 2006", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 8m,
                    DeveloperId = 1,
                    PublisherId = 1,
                    GenreId = 1,
                },
                new Game()
                {
                    Id = 2,
                    Name = "Elden Ring",
                    Description = "A New World Created By Hidetaka Miyazaki And George R. R. Martin ELDEN RING, developed by FromSoftware, Inc. and BANDAI NAMCO Entertainment Inc.",
                    Picture = "https://th.bing.com/th/id/OIF.pwBY1yiS46uxscEVyfb5HQ?rs=1&pid=ImgDetMain",
                    ReleaseDate = DateTime.ParseExact("FEB 25 - 2022", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 9.5m,
                    DeveloperId = 2,
                    PublisherId = 2,
                    GenreId = 4,
                },
                new Game()
                {
                    Id = 3,
                    Name = "Baldur's Gate 3",
                    Description = "An ancient evil has returned to Baldur's Gate, intent on devouring it from the inside out. The fate of Faerun lies in your hands. Alone, you may resist. But together, you can overcome.",
                    Picture = "https://mcdn.wallpapersafari.com/medium/59/58/Bh5wWX.jpg",
                    ReleaseDate = DateTime.ParseExact("Aug 3 - 2023", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 9.3m,
                    DeveloperId = 3,
                    PublisherId = 3,
                    GenreId = 3,
                },
                new Game()
                {
                    Id = 4,
                    Name = "The Witcher 3: Wild Hunt",
                    Description = "With the Empire attacking the Kingdoms of the North and the Wild Hunt, a cavalcade of ghastly riders, breathing down your neck, the only way to survive is to fight back. As Geralt of Rivia, a master swordsman and monster hunter, leave none of your enemies standing.",
                    Picture = "https://th.bing.com/th/id/OIP.ESLUrniRRUtzAk-LMGNjAAHaEK?pid=ImgDet&w=320&h=180&c=7",
                    ReleaseDate = DateTime.ParseExact("MAY 19 - 2015", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 9.0m,
                    DeveloperId = 4,
                    PublisherId = 4,
                    GenreId = 3,
                },
                new Game()
                {
                    Id = 5,
                    Name = "God of War: Ragnarok",
                    Description = "The freezing winds of Fimbulwinter have come to Midgard, making survival for Kratos, Atreus, and Mimir in the Norse wilds even more challenging than before. ",
                    Picture = "https://th.bing.com/th/id/OIP.jcAkvpdxr_5gQW0dm6_7VQHaJH?pid=ImgDet&w=146.25&h=180&c=7",
                    ReleaseDate = DateTime.ParseExact("NOV 9 - 2022", "MMM d - yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    AgeRating = "Rated M for Mature",
                    AgeRatingPicture = "https://www.metacritic.com/a/neutron/images/logos/esrb/ESRB_2013_M_Rating.png",
                    TotalScore = 8.1m,
                    DeveloperId = 5,
                    PublisherId = 5,
                    GenreId = 4,
                }
            };
        }

        private void SeedGamesPlatforms()
        {
            gamesPlatforms = new GamePlatform[]
            {
                new GamePlatform()
                {
                    GameId = 1,
                    PlatformId = 1
                },

                new GamePlatform()
                {
                    GameId = 1,
                    PlatformId = 2
                },

                new GamePlatform()
                {
                    GameId = 2,
                    PlatformId = 1
                },

                new GamePlatform()
                {
                    GameId = 2,
                    PlatformId = 3
                },

                new GamePlatform()
                {
                    GameId = 3,
                    PlatformId = 4
                },

                new GamePlatform()
                {
                    GameId = 4,
                    PlatformId = 1
                },

                new GamePlatform()
                {
                    GameId = 5,
                    PlatformId = 3
                },

                new GamePlatform()
                {
                    GameId = 5,
                    PlatformId = 4
                },


            };
        }

        private void SeedNews()
        {
            news = new News[] 
            { 
                new News() 
                {
                    Id = 1,
                    GameId = 2,
                    PublishDate = DateTime.Now,
                    Title = "DLC incoming",
                    Description = "Elden Ring DLC is fast approaching and the new trailer has ignited a fierce online debate about Messmer The Impaler's origins. Messmer The Impaler is supposedly the big bad in the Shadow of the Erdtree expansion, as the Collector's Edition even dedicates a fully detailed figurine to the soon-to-be-boss. But the lore implications around Messmer have split the player base in two, between those who believe he was teased from the very beginning to those who think he's an entirely new creation made for the DLC. Messmer is the figure with several snakes peeking up out of his red robes. Pair that with the all-new landmark trees that are at the center of the new Land of Shadows map, coiled around each other chaotically, and the imagery is clear. Messmer is the Satan stand-in. He's the original sinner against the Erdtree. "
                }
            };
        }
    }
}
