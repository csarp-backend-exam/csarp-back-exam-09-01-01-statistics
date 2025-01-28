using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;

namespace Kreta.Shared.Assamblers
{
    public class AddressAssambler : Assambler<Address, AddressDto>
    {
        public override AddressDto ToDto(Address domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override Address ToModel(AddressDto dto)
        {
            return dto.ToModel();
        }
    }
}
