using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class PublicSpaceRepo<TDbContext> : BaseRepo<TDbContext, PublicSpace>, IPublicSpaceRepo
        where TDbContext : DbContext
    {
        public PublicSpaceRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
