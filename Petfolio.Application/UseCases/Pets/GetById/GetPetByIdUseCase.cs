using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson()
        {
            Id = id,
            Name = "Bento Segundo",
            BirthDate = new DateTime(year: 2022, month: 10, day: 10),
            PetType = Communication.Enum.PetType.Dog
        };
    }
}