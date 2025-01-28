using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites.SwitchTable;

namespace Kreta.Shared.Assamblers
{
    public class TeachersTeachInSchoolClassAssambler : Assambler<TeachersTeachInSchoolClass, TeachersTeachInSchoolClassDto>
    {
        public override TeachersTeachInSchoolClassDto ToDto(TeachersTeachInSchoolClass domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override TeachersTeachInSchoolClass ToModel(TeachersTeachInSchoolClassDto dto)
        {
            return dto.ToModel();
        }
    }
}
