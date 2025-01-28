namespace Petfolio.Communication.Responses;

public class ResponseRegisterPetJson
{
    //Response do end-point de registrar pet
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}