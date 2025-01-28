using Kreta.Backend.Context;
using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites.SwitchTable;

namespace Kreta.Backend.Repos.SwitchTables
{
    public class SchoolClassStudentsRepo<TDbContext> : BaseRepo<TDbContext, SchoolClassStudents>, ISchoolClassStudentsRepo
        where TDbContext : KretaContext
    {
        public SchoolClassStudentsRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
