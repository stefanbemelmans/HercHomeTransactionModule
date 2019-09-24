namespace TransactionProject.Api.Features.AssetDefinition
{
  using MediatR;
  using TransactionProject.Api.Features.Base;

  public class CreateAssetDefinitionRequest : BaseRequest, IRequest<CreateAssetDefinitionResponse>
  {
    public const string ApiKey = "magicApiKey";
    public const string CreateAssetEndpoint = "create?api_key=" + ApiKey;
    public const string Route = "api/CreateAssetDefinition";

    /// <summary>
    /// The AssetDefintionDto which reflects the AssetDefintion you wish to create
    /// </summary>
    public AssetDefinitionDto AssetDefinitionDto { get; set; }
  }
}