namespace TransactionProject.Api.Features.JuliesApi
{
  using TransactionProject.Api.Features.Base;
  using MediatR;

  /// <summary>
  /// Get an AssetTransaction by TransactionKey
  /// </summary>
  public class ReturnSingleAssetTransactionApiRequest : BaseRequest, IRequest<ReturnSingleAssetTransactionApiResponse>
  {
    public const string Route = "api/ReturnSingleAssetTransaction";

    /// <summary>
    /// The AssetTransaction Key to get. 
    /// </summary>
    public int TransactionKey { get; set; }
  }
}
