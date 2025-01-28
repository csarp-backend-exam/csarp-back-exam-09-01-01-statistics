using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SubjectTypeRepo<TDbContext> : BaseRepo<TDbContext, SubjectType>, ISubjectTypeRepo
        where TDbContext : DbContext
    {
        public SubjectTypeRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
