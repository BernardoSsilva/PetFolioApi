
using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.delete;
using Petfolio.Application.UseCases.Pets.edit;
using Petfolio.Application.UseCases.Pets.get;
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
        [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]

        public IActionResult CreateNewPet([FromBody] PetRequest createPetBody)
        {
            RegisterPetUseCase useCase = new RegisterPetUseCase();
            var response = useCase.Execute(createPetBody);
            return Created(string.Empty,response);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePet([FromBody] PetRequest requestBody, string id) {
            UpdatePetUseCase useCase = new UpdatePetUseCase();
            useCase.Execute(id, requestBody);
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<PetDataResponse>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult getAllPets()
        {
            GetAllPetsUseCase useCase = new GetAllPetsUseCase();
            var allData = useCase.Execute();
            if (allData.Count == 0)
            {
                return NoContent();
            };
            return Ok(allData);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PetDataResponse), StatusCodes.Status200OK)]
        public IActionResult getPetById(string id)
        {
            GetPetByIdUseCase useCase = new GetPetByIdUseCase();
            return Ok(useCase.Execute(id));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult deletePetById(string id)
        {
            DeletePetUseCase useCase = new DeletePetUseCase();
            useCase.Execute(id)
            return NoContent();
        }
    }
}
