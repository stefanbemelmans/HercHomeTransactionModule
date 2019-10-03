namespace TransactionProject.Server.Services.JuliesApi
{
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetResponse
  {
    public AssetHeader SingleAsset { get; set; }

    public ReturnSingleAssetResponse()
    {
      SingleAsset = new AssetHeader();
    }
  }
}