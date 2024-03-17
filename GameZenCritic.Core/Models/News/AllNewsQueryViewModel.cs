using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Models.News
{
    public class AllNewsQueryViewModel
    {
        public int ItemsPerPage { get; } = 15;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; } = null!;

        public int Page { get; set; } = 1;
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }

        public IEnumerable<NewsShortInfoViewModel> News { get; set; } = new List<NewsShortInfoViewModel>();
    }
}
