using Kreta.Backend.Repos;
using Kreta.Backend.Services;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectController : BaseController<Subject, SubjectDto>
    {
        private readonly ISubjectRepo? _subjectRepo;
        public SubjectController(SubjectAssambler assambler, ISubjectRepo repo) : base(assambler, repo)
        {
            _subjectRepo = repo;
        }       
    }
}
