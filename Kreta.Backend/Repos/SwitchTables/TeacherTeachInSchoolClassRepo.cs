using Kreta.Backend.Context;
using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.Entites.SwitchTable;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos.SwitchTables
{
    public class TeacherTeachInSchoolClassRepo<TDbContext> : BaseRepo<TDbContext, TeachersTeachInSchoolClass>, ITeacherTeachInSchoolClass
        where TDbContext : KretaContext
    {
        public TeacherTeachInSchoolClassRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
