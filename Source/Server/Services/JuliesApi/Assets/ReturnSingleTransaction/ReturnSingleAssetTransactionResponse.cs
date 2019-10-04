namespace TransactionProject.Server.Services.JuliesApi
{
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetTransactionResponse
  {
    public SingleAssetHeaderDto SingleTransaction { get; set; }

    public ReturnSingleAssetTransactionResponse()
    {
      SingleTransaction = new SingleAssetHeaderDto();
    }
  }
}