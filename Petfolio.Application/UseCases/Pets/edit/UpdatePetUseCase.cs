using Petfolio.Application.entities;
using Petfolio.Application.Helpers;
using Petfolio.Communication.Request;
using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pets.edit
{
    public class UpdatePetUseCase
    {
        public void Execute(string id, PetRequest requestBody)
        {
            int petToEditIndex = LocalDatabase.LocalApplicationDatabase.FindIndex(pet => pet.id == id);

            LocalDatabase.LocalApplicationDatabase[petToEditIndex] = new PetEntity
            {
                id = id,
                Name = requestBody.Name,
                PetAge = requestBody.PetAge,
                Type = requestBody.Type
            };
        }
    }
}
