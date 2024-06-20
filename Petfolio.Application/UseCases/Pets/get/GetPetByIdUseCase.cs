using Petfolio.Application.entities;
using Petfolio.Application.Helpers;
using Petfolio.Communication.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Application.UseCases.Pets.get
{
    public class GetPetByIdUseCase
    {
        public PetDataResponse Execute(string id) {

            PetEntity response = LocalDatabase.LocalApplicationDatabase.Find(pet => pet.id == id);

            return new PetDataResponse
            {
                id = response.id,
                name = response.Name
            }; 
        }
    }
}
