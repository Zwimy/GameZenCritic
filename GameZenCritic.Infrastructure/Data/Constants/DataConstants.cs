using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Constants
{
    /// <summary>
    /// Data constants for all entities with respective values for validation
    /// </summary>
    public static class DataConstants
    {
        public const int DeveloperNameMaxLength = 100;
        public const int DeveloperNameMinLength = 2;

        public const int GameNameMaxLength = 180;
        public const int GameNameMinLength = 2;

        public const int GameDescriptionMaxLength = 500;
        public const int GameDescriptionMinLength = 10;

        public const int GamePictureMaxLength = 500;

        public const int GameAgeRatingMaxLength = 100;
        public const int GameAgeRatingMinLength = 2;

        public const int GameAgeRatingPictureMaxLength = 500;

        public const string GameTotalScoreMaxValue = "10";
        public const string GameTotalScoreMinValue = "0";
        public const string GameTotalScoreDbFormat = "decimal(4,2)";

        public const int GenreNameMaxLength = 100;
        public const int GenreNameMinLength = 2;

        public const int NewsTitleMaxLength = 200;
        public const int NewsTitleMinLength = 3;

        public const int NewsDescriptionMaxLength = 1000;
        public const int NewsDescriptionMinLength = 30;

        public const int PlatformNameMaxLength = 200;
        public const int PlatformNameMinLength = 2;

        public const int PublisherNameMaxLength = 100;
        public const int PublisherNameMinLength = 5;

        public const int PlayerUserNameMaxLength = 20;
        public const int PlayerEmailMaxLength = 60;

        public const int ReviewDescriptionMaxLength = 300;
        public const int ReviewDescriptionMinLength = 5;

        public const int ReviewScoreMaxValue = 10;
        public const int ReviewScoreMinValue = 0;
    }
}
