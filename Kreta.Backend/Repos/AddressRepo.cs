using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class AddressRepo<TDbContext> : BaseRepo<TDbContext, Address>, IAddressRepo
        where TDbContext : DbContext
    {
        public AddressRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
