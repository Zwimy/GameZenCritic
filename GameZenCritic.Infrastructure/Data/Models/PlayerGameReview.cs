using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Models
{
    public class PlayerGameReview
    {
        [Required]
        public string PlayerId { get; set; } = string.Empty;

        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; } = null!;

        [Required]
        public Guid GameId { get; set; }

        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; } = null!;

        [Required]
        [StringLength(300)]
        public string Details { get; set; } = string.Empty;

        [Required]
        [Range(0,10)]
        public int Score { get; set; }
    }
}
