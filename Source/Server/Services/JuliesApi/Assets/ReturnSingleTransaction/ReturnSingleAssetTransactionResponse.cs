namespace TransactionProject.Server.Services.JuliesApi
{
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetTransactionResponse
  {
    public SingleTransaction SingleTransaction { get; set; }

    public ReturnSingleAssetTransactionResponse()
    {
      SingleTransaction = new SingleTransaction();
    }
  }
}