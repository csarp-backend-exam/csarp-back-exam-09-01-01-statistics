using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class GradeRepo<TDbContext> : BaseRepo<TDbContext, Grade>, IGradeRepo
        where TDbContext : DbContext
    {
        public GradeRepo(TDbContext? dbContext) : base(dbContext)
        {

        }
    }
}
