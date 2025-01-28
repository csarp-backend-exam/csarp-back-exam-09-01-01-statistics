using Kreta.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers.Statistics
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatisticController : ControllerBase
    {
        private IStatisticRepo _statisticRepo;

        public StatisticController(IStatisticRepo statisticRepo)
        {
            _statisticRepo = statisticRepo;
        }

    }
}
