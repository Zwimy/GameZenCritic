using GameZenCritic.Core.Contracts;
using GameZenCritic.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository repository;

        public GameService(IRepository _repository)
        {
            repository = _repository;
        }


    }
}
