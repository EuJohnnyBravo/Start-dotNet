using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Register;

public class RegisterPetUseCase
{
    //o rentordo da requisição de registrar um pet
    public ResponseRegisterPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisterPetJson()
        {
            Id = 7,
            Name = "Bento"
        };
    }
}