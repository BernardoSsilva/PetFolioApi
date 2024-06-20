
using Petfolio.Communication.enums;
namespace Petfolio.Communication.Request
{
    public class CreatePetRequest
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public required string Name { get; set; }
        public required int PetAge { get; set; }
        public PetType Type { get; set; }
    }
}
