namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
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
      ReturnSingleAssetResponse aReturnSingleAssetResponse = await JuliesApi.GetJsonAsync<ReturnSingleAssetResponse>(ReturnSingleAssetDefintionApiRequest.Route);

      return new ReturnSingleAssetResponse { SingleAsset = aReturnSingleAssetResponse.SingleAsset };
    }
  }
}