using Kreta.Shared.Models.Entites.SchoolCitizens;

namespace Kreta.Shared.Models.Entites
{
    public class EducationLevel : IDbEntity<EducationLevel>
    {
        public Guid Id { get; set; }
        public string StudentEducationLevel { get; set; } = string.Empty;
        public int DurationOfEducation { get; set; }
        public virtual ICollection<Student>? Students { get; set; } = new List<Student>();
        public bool HasId => Id != Guid.Empty;

        public override string ToString()
        {
            return $"{StudentEducationLevel} ({DurationOfEducation})";
        }

    }
}
