using Petfolio.Application.entities;
using Petfolio.Application.Helpers;
using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pets.get
{
    public class GetAllPetsUseCase
    {

        public List<PetDataResponse> Execute()
        {

            List<PetEntity> allPets = LocalDatabase.LocalApplicationDatabase;

            List<PetDataResponse> response = [];
            foreach(var pet in allPets)
            {
                response.Add(new PetDataResponse
                {
                    id = pet.id,
                    name = pet.Name
                });
            }


            return response;
        }
    }
}
