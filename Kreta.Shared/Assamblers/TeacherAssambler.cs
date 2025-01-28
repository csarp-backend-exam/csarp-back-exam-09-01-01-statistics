using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites.SchoolCitizens;

namespace Kreta.Shared.Assamblers
{
    public class TeacherAssambler : Assambler<Teacher, TeacherDto>
    {
        public override TeacherDto ToDto(Teacher model)
        {
            return model.ToDto();
        }

        public override Teacher ToModel(TeacherDto dto)
        {
            return dto.ToModel();
        }
    }
}
