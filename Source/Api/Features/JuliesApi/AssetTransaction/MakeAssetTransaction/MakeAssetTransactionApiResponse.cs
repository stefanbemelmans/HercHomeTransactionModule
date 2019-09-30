namespace TransactionProject.Api.Features.JuliesApi
{
  using System;
  using TransactionProject.Api.Features.Base;

  public class MakeAssetTransactionApiResponse : BaseResponse
  {
    public MakeAssetTransactionApiResponse() { }
    public MakeAssetTransactionApiResponse(Guid aRequestId) : base(aRequestId) { }
    public string AssetKey { get; set; }
  }
}