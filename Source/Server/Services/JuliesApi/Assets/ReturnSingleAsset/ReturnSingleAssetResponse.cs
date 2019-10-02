using TransactionProject.Api.Features.JuliesApi;

namespace TransactionProject.Server.Services.JuliesApi
{
  public class ReturnSingleAssetResponse
  {
    public AssetDefinitionDto SingleAsset { get; set; }

    public ReturnSingleAssetResponse()
    {
      SingleAsset = new AssetDefinitionDto();
    }
  }
}