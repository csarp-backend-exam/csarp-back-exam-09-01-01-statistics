using Kreta.Backend.Repos.SwitchTables;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites.SwitchTable;
using Kreta.Shared.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolClassSubjectsController : BaseController<SchoolClassSubjects, SchoolClassSubjectsDto>
    {
        private readonly ISchoolClassSubjectsRepo schoolClassSubjectRepo;
        public SchoolClassSubjectsController( SchoolClassSubjectsAssambler assambler, ISchoolClassSubjectsRepo repo) : base(assambler, repo)
        {
            schoolClassSubjectRepo = repo;
        }        
    }
}
