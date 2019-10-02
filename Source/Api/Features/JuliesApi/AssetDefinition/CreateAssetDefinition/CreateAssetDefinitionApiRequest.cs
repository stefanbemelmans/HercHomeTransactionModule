namespace TransactionProject.Api.Features.JuliesApi
{
  using MediatR;
  using TransactionProject.Api.Features.Base;

  public class CreateAssetDefinitionApiRequest : BaseRequest, IRequest<CreateAssetDefintionApiResponse>
  {
    public const string ApiKey = "magicApiKey";
    public const string CreateAssetEndpoint = "create?api_key=" + TempApiKey.ApiKey;
    public const string Route = "api/CreateAssetDef";

    public AssetDefinitionDto AssetDefinitionDto { get; set; }
  }
}