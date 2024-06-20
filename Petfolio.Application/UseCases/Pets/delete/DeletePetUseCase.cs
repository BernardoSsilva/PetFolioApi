using Petfolio.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Application.UseCases.Pets.delete
{
    public class DeletePetUseCase
    {
        public void Execute(string id)
        {
            int petToRemoveIndex = LocalDatabase.LocalApplicationDatabase.FindIndex(pet => pet.id == id);

            LocalDatabase.LocalApplicationDatabase.RemoveAt(petToRemoveIndex);
        }
    }
}
