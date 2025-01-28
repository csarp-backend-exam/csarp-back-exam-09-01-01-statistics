using Kreta.Backend.Repos.Managers;
using Kreta.Shared.Models.Entites;

namespace Kreta.Backend.Services
{
    public class SchoolClassSubjectService : ISchoolClassSubjectService
    {
        private readonly IRepositoryManager? _repositoryManager;
        public SchoolClassSubjectService(IRepositoryManager? repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }        
    }
}
