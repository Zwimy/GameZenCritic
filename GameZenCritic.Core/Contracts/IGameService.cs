﻿using GameZenCritic.Core.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Contracts
{
    public interface IGameService
    {
        Task<TopGamesAndDevelopersViewModel> TopGamesInfoAsync();
    }
}
