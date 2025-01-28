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
    public class TeacherTeachInSchoolClassController : BaseController<TeachersTeachInSchoolClass, TeachersTeachInSchoolClassDto>
    {
        private readonly ITeacherTeachInSchoolClass? _teacherTeachInSchoolClassRepo;

        public TeacherTeachInSchoolClassController(TeachersTeachInSchoolClassAssambler? assambler, ITeacherTeachInSchoolClass? repo) : base(assambler, repo)
        {
            _teacherTeachInSchoolClassRepo= repo;
        }      
    }
}
