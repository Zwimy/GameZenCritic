using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameZenCritic.Infrastructure.Data
{
    public class GameZenDbContext : IdentityDbContext
    {
        public GameZenDbContext(DbContextOptions<GameZenDbContext> options)
            : base(options)
        {
        }
    }
}
