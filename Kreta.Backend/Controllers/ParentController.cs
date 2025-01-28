using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites.SchoolCitizens;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentController : BaseController<Parent, ParentDto>
    {
        public ParentController(ParentAssambler? assambler, IParentRepo? repo) : base(assambler, repo)
        {
        }
    }
}
