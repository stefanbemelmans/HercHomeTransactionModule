using TransactionProject.Api.Features.Base;
using MediatR;

namespace TransactionProject.Api.Features.JuliesApi
{
  /// <summary>
  /// Get an AssetDefinition by ID
  /// </summary>
  public class GetAssetDefinitionRequest: BaseRequest, IRequest<GetAssetDefinitionResponse>
  {
    public const string Route = "api/GetAssetDefinition";

    /// <summary>
    /// The AssetDefinitionId to get. 
    /// </summary>
    public int AssetDefinitionId { get; set; }
  }
}
