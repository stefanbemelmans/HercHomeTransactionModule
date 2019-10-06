namespace TransactionProject.Server.Services.JuliesApi
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnTransactionsOnASingleAssetResponse
  {
    public Dictionary<string, Transaction> AssetTransactionList { get; set; }
  }
}