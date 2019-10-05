namespace TransactionProject.Server.Services.JuliesApi
{
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetTransactionResponse
  {
    public Transaction SingleTransaction { get; set; }

    public ReturnSingleAssetTransactionResponse()
    {
      SingleTransaction = new Transaction();
    }
  }
}