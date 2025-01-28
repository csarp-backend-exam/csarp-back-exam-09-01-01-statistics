using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites.SchoolCitizens;

namespace Kreta.Shared.Assamblers
{
    public class ParentAssambler : Assambler<Parent, ParentDto>
    {
        public override ParentDto ToDto(Parent model)
        {
            return model.ToDto();
        }

        public override Parent ToModel(ParentDto dto)
        {
            return dto.ToModel();
        }
    }
}
