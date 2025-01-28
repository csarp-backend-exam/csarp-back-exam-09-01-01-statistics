using Kreta.Backend.Context;
using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites.SwitchTable;
using Kreta.Shared.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos.SwitchTables
{
    public class SchoolClassSubjectsRepo<TDbContext> : BaseRepo<TDbContext, SchoolClassSubjects>, ISchoolClassSubjectsRepo
        where TDbContext : KretaContext
    {
        public SchoolClassSubjectsRepo(TDbContext? dbContext) : base(dbContext)
        {
        }       
    }
}
