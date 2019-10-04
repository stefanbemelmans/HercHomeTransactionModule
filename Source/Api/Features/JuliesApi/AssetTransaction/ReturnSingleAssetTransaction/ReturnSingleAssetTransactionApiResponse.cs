namespace TransactionProject.Api.Features.JuliesApi
{
  using System;
  using TransactionProject.Api.Features.Base;

  /// <summary>
  /// Returns the AssetTransactionDto if found
  /// </summary>
  public class ReturnSingleAssetTransactionApiResponse : BaseResponse
  {
    /// <summary>
    /// The AssetTransaction requested if found else null.
    /// </summary>
    public SingleAssetHeaderDto AssetTransaction { get; set; }

    public ReturnSingleAssetTransactionApiResponse() { }

    public ReturnSingleAssetTransactionApiResponse(Guid aRequestId) : base(aRequestId) { }
  }
}