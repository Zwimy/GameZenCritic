using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static GameZenCritic.Core.Constants.LogicConstants;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Models.Contracts
{
    public class QueryModel
    {
        public virtual int ItemsPerPage { get; }

        [Display(Name = "Search by text")]
        public virtual string? SearchTerm { get; init; } = null;

        public virtual int Page { get; set; } = StartPage;
        public virtual int TotalPages { get; set; }

        public virtual int TotalCount { get; set; }
    }
}
