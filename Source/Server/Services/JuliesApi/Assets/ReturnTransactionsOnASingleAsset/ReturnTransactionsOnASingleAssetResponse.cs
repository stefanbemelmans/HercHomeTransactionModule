namespace TransactionProject.Server.Services.JuliesApi.Assets.ReturnTransactionsOnASingleAsset
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnTransactionsOnASingleAssetResponse
    {
        public List<AssetTransactionDto> TransactionList { get; set; }

    }
}
