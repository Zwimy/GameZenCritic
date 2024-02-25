﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Models
{
    /// <summary>
    /// List of the games and platforms, many to many related
    /// </summary>
    [Comment("List of the games and platforms, many to many related")]
    public class GamePlatform
    {
        /// <summary>
        /// Game identifier and key relation
        /// </summary>
        [Comment("Game key")]
        [Required]
        public Guid GameId { get; set; }

        [Comment("Game identifier")]
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; } = null!;

        /// <summary>
        /// Platform identifier and key relation
        /// </summary>
        [Comment("Platform key")]
        [Required]
        public int PlatformId { get; set; }

        [Comment("Platform identifier")]
        [ForeignKey(nameof(PlatformId))]
        public Platform Platform { get; set; } = null!;
    }
}