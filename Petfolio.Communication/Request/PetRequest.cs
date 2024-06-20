
using Petfolio.Communication.enums;
namespace Petfolio.Communication.Request
{
    public class PetRequest
    {
        public required string Name { get; set; }
        public required int PetAge { get; set; }
        public PetType Type { get; set; }
    }
}
