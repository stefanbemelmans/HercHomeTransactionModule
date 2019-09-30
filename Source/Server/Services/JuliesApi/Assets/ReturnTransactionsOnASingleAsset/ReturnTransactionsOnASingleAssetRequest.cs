namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;

  public class ReturnTransactionsOnASingleAssetRequest : IRequest<ReturnTransactionsOnASingleAssetResponse>
  {
    public string AssetKey { get; set; }
  }
}