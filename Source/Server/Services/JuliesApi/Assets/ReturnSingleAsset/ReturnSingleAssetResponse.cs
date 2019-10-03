namespace TransactionProject.Server.Services.JuliesApi
{
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetResponse
  {
    public AssetHeaderDto SingleAsset { get; set; }

    public ReturnSingleAssetResponse()
    {
      SingleAsset = new AssetHeaderDto();
    }
  }
}