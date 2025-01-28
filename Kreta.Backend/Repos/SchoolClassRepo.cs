using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SchoolClassRepo<TDbContext> : BaseRepo<TDbContext, SchoolClass>, ISchoolClassRepo
        where TDbContext : DbContext
    {
        public SchoolClassRepo(TDbContext? dbContext) : base(dbContext)
        {
        }        
    }
}
