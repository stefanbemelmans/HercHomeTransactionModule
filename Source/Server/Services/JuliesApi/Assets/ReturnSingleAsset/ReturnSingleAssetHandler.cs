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
      object jsonResponse = await JuliesApi.SendJsonAsync<object>(
        HttpMethod.Get,
        ReturnSingleAssetApiRequest.ReturnSingleAssetEndpoint,
        new ReturnSingleAssetRequest { AssetKey = aReturnSingleAssetRequest.AssetKey }
        );

      string responseString = jsonResponse.ToString();

      SingleAssetHeaderDto aSingleAsset = JsonSerializer.Deserialize<SingleAssetHeaderDto>(responseString);

      return new ReturnSingleAssetResponse { SingleAsset = aSingleAsset };
    }
  }
}