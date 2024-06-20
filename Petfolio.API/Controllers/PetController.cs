
using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.RegisterPet;
using Petfolio.Communication.Request;
using Petfolio.Communication.Response;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(PetDataResponse), StatusCodes.Status201Created)]
        public IActionResult CreateNewPet([FromBody] CreatePetRequest createPetBody)
        {
            RegisterPetUseCase useCase = new RegisterPetUseCase();
            var response = useCase.Execute(createPetBody);
            return Created(string.Empty,response);
        }
    }
}
