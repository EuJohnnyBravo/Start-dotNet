using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Requests;

public class RequestPetJson
{
    //body da requisição
    public string Name { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public PetType Type { get; set; }
}