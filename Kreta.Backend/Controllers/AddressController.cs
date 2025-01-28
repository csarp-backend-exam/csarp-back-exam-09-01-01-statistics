using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : BaseController<Address, AddressDto>
    {
        public AddressController(AddressAssambler assambler, IAddressRepo? repo) : base(assambler, repo)
        {
        }
    }
}
