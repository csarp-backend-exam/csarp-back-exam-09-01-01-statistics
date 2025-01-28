using Kreta.Shared.Models.Entites;
using Kreta.Shared.Models.Entites.SchoolCitizens;
using Kreta.Shared.Models.Entites.SwitchTable;

namespace Kreta.Shared.Models
{
    public class SchoolClassDto
    {
        public Guid Id { get; set; }
        public bool HasId => Id != Guid.Empty;
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClassType { get; set; }
        public Guid? TypeOfEducationId { get; set; }
        public virtual TypeOfEducation? TypeOfEducation { get; set; }
        public Guid? HeadTeacherId { get; set; }
        public virtual Teacher? HeadTeacher { get; set; }
        public int YearOfEnrolment { get; set; }
        public bool IsArchived { get; set; }
        public ICollection<SchoolClassSubjects>? SchoolClassSubjects { get; set; }
        public virtual ICollection<Student>? StudentsOfClass { get; set; }
        public virtual ICollection<TeachersTeachInSchoolClass>? TeacherWhoTeachInSchoolClass { get; set; }
    }
}
