namespace TransactionProject.Api.Features.JuliesApi
{
  using MediatR;
  using TransactionProject.Api.Features.Base;

  public class CreateAssetDefRequest : BaseRequest, IRequest<CreateAssetDefResponse>
  {
    public const string ApiKey = "magicApiKey";
    public const string CreateAssetEndpoint = "create?api_key=";
    public const string Route = "api/CreateAssetDef";

    /// <summary>
    /// The AssetDefintionDto which reflects the AssetDefintion you wish to create
    /// </summary>
    public AssetDefinitionDto AssetDefinitionDto { get; set; }
  }
}