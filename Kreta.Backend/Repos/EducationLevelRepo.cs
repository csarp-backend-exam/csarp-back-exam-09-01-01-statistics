using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class EducationLevelRepo<TDbContext> : BaseRepo<TDbContext, EducationLevel>, IEducationLevelRepo
        where TDbContext : DbContext
    {
        public EducationLevelRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
