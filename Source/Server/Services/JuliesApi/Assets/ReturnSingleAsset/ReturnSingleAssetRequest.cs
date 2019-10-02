namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;

  public class ReturnSingleAssetRequest : IRequest<ReturnSingleAssetResponse>
  {
    public string AssetKey { get; set; }
  }
}