namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Net.Http;
  using System.Text.Json;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetHandler : IRequestHandler<ReturnSingleAssetRequest, ReturnSingleAssetResponse>
  {
    public JuliesApiHttpClient JuliesApi { get; set; }

    public ReturnSingleAssetHandler(JuliesApiHttpClient aJuliesApi)
    {
      JuliesApi = aJuliesApi;
    }

    public async Task<ReturnSingleAssetResponse> Handle
      (
      ReturnSingleAssetRequest aReturnSingleAssetRequest,
      CancellationToken aCancellationToken
      )
    {
      object response = await JuliesApi.SendJsonAsync<ReturnSingleAssetResponse>(
        HttpMethod.Get,
        ReturnSingleAssetDefintionApiRequest.ReturnSingleAssetDefinitionEndpoint,
        new ReturnSingleAssetRequest { AssetKey = aReturnSingleAssetRequest.AssetKey }
        );

      string responseString = response.ToString();

      AssetHeaderDto aSingleAsset = JsonSerializer.Deserialize<AssetHeaderDto>(responseString);

      return new ReturnSingleAssetResponse { SingleAsset = aSingleAsset };
    }
  }
}