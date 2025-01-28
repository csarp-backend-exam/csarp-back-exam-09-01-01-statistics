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
    public class TypeOfEducationController : BaseController<TypeOfEducation, TypeOfEducationDto>
    {
        private readonly ITypeOfEducationRepo? _typeOfEducationRepo;
        public TypeOfEducationController(TypeOfEducationAssambler? assambler, ITypeOfEducationRepo? repo) : base(assambler, repo)
        {
            _typeOfEducationRepo = repo;
        }        
    }
}
