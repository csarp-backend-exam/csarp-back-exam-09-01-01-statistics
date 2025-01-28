using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class StudentRepo<TDbContext> : BaseRepo<TDbContext, Student>, IStudentRepo
        where TDbContext : DbContext
    {
        public StudentRepo(TDbContext? dbContext) : base(dbContext)
        {
        }       
    }
}
