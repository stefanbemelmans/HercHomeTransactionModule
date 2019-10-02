using TransactionProject.Api.Features.Base;
using MediatR;

namespace TransactionProject.Api.Features.JuliesApi
{
  /// <summary>
  /// Get an AssetDefinition by AssetKey
  /// </summary>
  public class ReturnSingleAssetDefintionApiRequest : BaseRequest, IRequest<ReturnSingleAssetDefinitionApiResponse>
  {
    public const string Route = "api/ReturnSingleAssetDefinition";

    /// <summary>
    /// The AssetDefinition Key to get. 
    /// </summary>
    public int AssetKey { get; set; }
  }
}
