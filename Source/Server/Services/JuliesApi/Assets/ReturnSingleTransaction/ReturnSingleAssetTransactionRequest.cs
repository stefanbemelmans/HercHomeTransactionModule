namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using System;

  public class ReturnSingleAssetTransactionRequest : IRequest<ReturnSingleAssetTransactionResponse>
  {
    public string assetKey { get; set; }
    public long timestamp { get; set; }
  }
}