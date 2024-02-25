﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Models
{
    /// <summary>
    /// Platform object inclusing identifier and name
    /// </summary>
    [Comment("Platform list inclusing identifier and name")]
    public class Platform
    {
        /// <summary>
        /// Platform identifier key
        /// </summary>
        [Comment("Platform identifier key")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Platform name
        /// </summary>
        [Comment("Platform name")]
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;
    }
}
