namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;

  public class ReturnSingleAssetTransactionRequest : IRequest<ReturnSingleAssetTransactionResponse>
  {
    public string TransactionKey { get; set; }
  }
}