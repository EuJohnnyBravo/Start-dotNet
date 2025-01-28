using System.Runtime.InteropServices.JavaScript;

namespace Petfolio.Communication.Responses;

public class ResponseErrorsJson
{
    //Lista de possiveis erros durante a aplicação
    public List<string> Errors { get; set; } = [];
}