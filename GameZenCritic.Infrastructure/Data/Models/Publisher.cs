using System.ComponentModel.DataAnnotations;

namespace GameZenCritic.Infrastructure.Data.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Game> Games { get; set; } = new List<Game>();

        public bool IsDeleted { get; set; } = false;
    }
}