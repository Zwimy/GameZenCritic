using GameZenCritic.Infrastructure.Data.Constants;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Models
{
    /// <summary>
    /// Player class using IdentityUser implementation
    /// </summary>
    public class Player : IdentityUser
    {
        [Required]
        [MaxLength(DataConstants.PlayerUserNameMaxLength)]
        public override string UserName
        {
            get => base.UserName;
            set => base.UserName = value;
        }

        [Required]
        [MaxLength(DataConstants.PlayerEmailMaxLength)]
        public override string Email
        {
            get => base.Email;
            set => base.Email = value;
        }

        /// <summary>
        /// Navigational property to PlayersGamesReviews
        /// </summary>
        public virtual ICollection<PlayerGameReview> PlayersGamesReviews { get; set; } = new List<PlayerGameReview>();

    }
}
