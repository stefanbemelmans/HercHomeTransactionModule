namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnListOfAssetsHandler : IRequestHandler<ReturnListOfAssetsRequest, ReturnListOfAssetsResponse>
  {
    public JuliesApiHttpClient JuliesApi { get; set; }

    public ReturnListOfAssetsHandler(JuliesApiHttpClient aJuliesApi)
    {
      JuliesApi = aJuliesApi;
    }

    public async Task<ReturnListOfAssetsResponse> Handle
      (
      ReturnListOfAssetsRequest aReturnListOfAssetsRequest,
      CancellationToken aCancellationToken
      )
    {
      ReturnListOfAssetsResponse aReturnListOfAssetsResponse = await JuliesApi.GetJsonAsync<ReturnListOfAssetsResponse>(ReturnListOfAssetsApiRequest.ReturnListOfAssetsEndPoint);

      return new ReturnListOfAssetsResponse { AssetList = aReturnListOfAssetsResponse.AssetList };
    }
  }
}