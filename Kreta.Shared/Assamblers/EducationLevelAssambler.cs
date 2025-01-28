using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;

namespace Kreta.Shared.Assamblers
{
    public class EducationLevelAssambler : Assambler<EducationLevel, EducationLevelDto>
    {
        public override EducationLevelDto ToDto(EducationLevel domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override EducationLevel ToModel(EducationLevelDto dto)
        {
            return dto.ToModel();
        }
    }
}
