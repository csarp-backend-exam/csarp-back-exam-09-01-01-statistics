using Kreta.Backend.Repos.Managers;
using Kreta.Shared.Models.Dtos.Statistics;
using Kreta.Shared.Models.Entites;

namespace Kreta.Backend.Repos
{
    public class StatisticRepo : IStatisticRepo
    {
        private readonly IRepositoryManager? _repositoryManager;

        public StatisticRepo(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }  
    }
}
