using Kreta.Shared.Models.Entites;
using Kreta.Shared.Models.Entites.SchoolCitizens;

namespace Kreta.Shared.Models
{
    public class TeachersTeachInSchoolClassDto
    {
        public Guid Id { get; set; }
        public Guid TeacherId { get; set; }
        public virtual Teacher? TeacherTeachInScoolClass { get; set; }
        public Guid SchoolClassId { get; set; }
        public virtual SchoolClass? SchoolClassWhoTeacherTeach { get; set; }
        public int NumberOfHours { get; set; }
        public bool IsTheHoursInOne { get; set; }
    }
}
