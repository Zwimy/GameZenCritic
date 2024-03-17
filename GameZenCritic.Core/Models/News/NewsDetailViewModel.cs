using GameZenCritic.Core.Models.Game;
using GameZenCritic.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Models.News
{
    public class NewsDetailViewModel
    {
        /// <summary>
        /// Identifying key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Game identifier
        /// </summary>
        [Required]
        public int GameId { get; set; }

        /// <summary>
        /// Title for the news article
        /// </summary>
        [Required]
        [StringLength(DataConstants.NewsTitleMaxLength)]
        [MinLength(DataConstants.NewsTitleMinLength)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Text description for the news article
        /// </summary>
        [Required]
        [StringLength(DataConstants.NewsDescriptionMaxLength)]
        [MinLength(DataConstants.NewsDescriptionMinLength)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// When the article  is published
        /// </summary>
        [Required]
        public DateTime PublishDate { get; set; }
    }
}
