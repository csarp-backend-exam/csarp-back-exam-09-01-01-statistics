using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationLevelController : BaseController<EducationLevel, EducationLevelDto>
    {
        private readonly IEducationLevelRepo? _educationLevelRepo;
        public EducationLevelController(EducationLevelAssambler? assambler, IEducationLevelRepo? repo) : base(assambler, repo)
        {
            _educationLevelRepo = repo;
        }
    }
}
