using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Models
{
    public class Player : IdentityUser
    {
        [Required]
        [MaxLength(20)]
        public override string UserName
        {
            get => base.UserName;
            set => base.UserName = value;
        }

        [Required]
        [MaxLength(60)]
        public override string Email
        {
            get => base.Email;
            set => base.Email = value;
        }

        public virtual ICollection<PlayerGameReview> PlayersGamesReviews { get; set; } = new List<PlayerGameReview>();

    }
}
