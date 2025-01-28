using Kreta.Backend.Repos;
using Kreta.Backend.Repos.SwitchTables;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites.SwitchTable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolClassStudentsController : BaseController<SchoolClassStudents, SchoolClassStudentsDto>
    {
        private readonly ISchoolClassStudentsRepo? _schoolClassStudentsRepo;
        public SchoolClassStudentsController(SchoolClassStudentsAssambler assambler, ISchoolClassStudentsRepo? repo) : base(assambler, repo)
        {
            _schoolClassStudentsRepo = repo;
        }       

    }
}
