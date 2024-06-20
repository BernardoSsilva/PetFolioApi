using Petfolio.Application.entities;
using Petfolio.Application.Helpers;
using Petfolio.Communication.Request;
using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pets.RegisterPet
{
    public class RegisterPetUseCase
    {
        public PetDataResponse Execute(PetRequest request)
        {

            PetEntity newPet = new PetEntity
            {
                Name = request.Name,
                PetAge = request.PetAge,
                Type = request.Type
            };
            LocalDatabase.LocalApplicationDatabase.Add(newPet);
            return new PetDataResponse
            {
                id = newPet.id,
                name = newPet.Name
            };
        }
    }
}
