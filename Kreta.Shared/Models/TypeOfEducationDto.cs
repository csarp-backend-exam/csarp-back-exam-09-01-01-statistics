using Kreta.Shared.Models.Entites;

namespace Kreta.Shared.Models
{
    public class TypeOfEducationDto
    {
        public Guid Id { get; set; }
        public string EducationName { get; set; } = string.Empty;
        public virtual ICollection<SchoolClass>? SchoolClasses { get; set; } = new List<SchoolClass>();
    }
}
