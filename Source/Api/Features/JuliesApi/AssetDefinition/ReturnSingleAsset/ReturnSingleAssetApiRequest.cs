namespace TransactionProject.Api.Features.JuliesApi
{
  using TransactionProject.Api.Features.Base;
  using MediatR;

  /// <summary>
  /// Get an AssetDefinition by AssetKey
  /// </summary>
  public class ReturnSingleAssetApiRequest : BaseRequest, IRequest<ReturnSingleAssetApiResponse>
  {
    public const string Route = "api/ReturnSingleAsset";
    public const string ReturnSingleAssetEndpoint = "assets/single?api_key=" + TempApiKey.ApiKey;
    /// <summary>
    /// The AssetDefinition Key to get. 
    /// </summary>
    public int AssetKey { get; set; }
  }
}
