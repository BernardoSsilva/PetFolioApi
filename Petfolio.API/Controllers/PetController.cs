
using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication.Request;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {

        [HttpPost]
        public IActionResult CreateNewPet([FromBody] CreatePetRequest createPetBody)
        {

        }
    }
}
