using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites.SchoolCitizens;

namespace Kreta.Shared.Assamblers
{
    public class StudentAssambler : Assambler<Student, StudentDto>
    {
        public override StudentDto ToDto(Student model)
        {
            return model.ToDto();
        }

        public override Student ToModel(StudentDto dto)
        {
            return dto.ToModel();
        }
    }
}
