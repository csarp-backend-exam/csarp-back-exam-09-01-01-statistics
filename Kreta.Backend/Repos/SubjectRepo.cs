using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SubjectRepo<TDbContext> : BaseRepo<TDbContext, Subject>, ISubjectRepo
        where TDbContext : DbContext
    {
        public SubjectRepo(TDbContext? dbContext) : base(dbContext)
        {

        }
    }
}
