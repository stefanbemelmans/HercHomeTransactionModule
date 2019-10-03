namespace TransactionProject.Server.Services.JuliesApi
{
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetTransactionResponse
  {
    public AssetHeaderDto SingleTransaction { get; set; }

    public ReturnSingleAssetTransactionResponse()
    {
      SingleTransaction = new AssetHeaderDto();
    }
  }
}