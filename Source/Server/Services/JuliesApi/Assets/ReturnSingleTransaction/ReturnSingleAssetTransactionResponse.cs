namespace TransactionProject.Server.Services.JuliesApi
{
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetTransactionResponse
  {
    public AssetTransactionDto SingleTransaction { get; set; }

    public ReturnSingleAssetTransactionResponse()
    {
      SingleTransaction = new AssetTransactionDto();
    }
  }
}