namespace TransactionProject.Api.Features.JuliesApi
{
  using MediatR;
  using TransactionProject.Api.Features.Base;

  public class CreateAssetDefinitionApiRequest : BaseRequest, IRequest<CreateAssetDefintionApiResponse>
  {
    public const string ApiKey = "magicApiKey";
    public const string CreateAssetEndpoint = "create?api_key="+ApiKey;
    public const string Route = "api/CreateAssetDef";

    /// <summary>
    /// The AssetDefintionDto which reflects the AssetDefintion you wish to create
    /// </summary>
    public AssetDefinitionDto AssetDefinitionDto { get; set; }
  }
}