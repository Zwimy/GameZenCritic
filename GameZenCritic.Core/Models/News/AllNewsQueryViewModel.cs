using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static GameZenCritic.Core.Constants.LogicConstants;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameZenCritic.Core.Models.Contracts;

namespace GameZenCritic.Core.Models.News
{
    public class AllNewsQueryViewModel : QueryModel
    {
        public override int ItemsPerPage { get; } = NewsItemsPerPage;

        public IEnumerable<NewsShortInfoViewModel> News { get; set; } = new List<NewsShortInfoViewModel>();
    }
}
