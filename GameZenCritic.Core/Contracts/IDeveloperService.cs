using GameZenCritic.Core.Models.Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Contracts
{
    public interface IDeveloperService
    {
        Task <IEnumerable<DeveloperInfoViewModel>> GetAllAsync();
        Task <DeveloperInfoViewModel> GetTopDeveloperInfoAsync ();

        Task<DeveloperDetailsQueryViewModel?> GetByIdAsync(int id, int page);
    }
}
