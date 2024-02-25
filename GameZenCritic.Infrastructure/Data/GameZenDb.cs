using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameZenCritic.Infrastructure.Data
{
    public class GameZenDb : IdentityDbContext
    {
        public GameZenDb(DbContextOptions<GameZenDb> options)
            : base(options)
        {
        }
    }
}
