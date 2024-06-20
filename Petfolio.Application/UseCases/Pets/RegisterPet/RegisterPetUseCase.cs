using Petfolio.Communication.Request;
using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pets.RegisterPet
{
    public class RegisterPetUseCase
    {
        public PetDataResponse Execute(CreatePetRequest request)
        {
            return new PetDataResponse
            {
                id = request.id,
                name = request.Name
            };
        }
    }
}
