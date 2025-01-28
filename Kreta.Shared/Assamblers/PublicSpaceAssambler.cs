using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;

namespace Kreta.Shared.Assamblers
{
    public class PublicSpaceAssambler : Assambler<PublicSpace, PublicSpaceDto>
    {
        public override PublicSpaceDto ToDto(PublicSpace domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override PublicSpace ToModel(PublicSpaceDto dto)
        {
            return dto.ToModel();
        }
    }
}
