namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnTransactionsOnASingleAssetHandler : IRequestHandler<ReturnTransactionsOnASingleAssetRequest, ReturnTransactionsOnASingleAssetResponse>
  {
    public JuliesApiHttpClient JuliesApi { get; set; }

    public ReturnTransactionsOnASingleAssetHandler(JuliesApiHttpClient aJuliesApi)
    {
      JuliesApi = aJuliesApi;
    }

    public async Task<ReturnTransactionsOnASingleAssetResponse> Handle
      (
      ReturnTransactionsOnASingleAssetRequest aReturnTransactionsOnASingleAssetRequest,
      CancellationToken aCancellationToken
      )
    {
      ReturnTransactionsOnASingleAssetResponse getAssetTransactionsRequest = await JuliesApi.PostJsonAsync<ReturnTransactionsOnASingleAssetResponse>(ReturnTransactionsOnASingleAssetApiRequest.GetAssetTransEndpoint, new ReturnTransactionsOnASingleAssetRequest
      {
        AssetKey = aReturnTransactionsOnASingleAssetRequest.AssetKey
      });
      return new ReturnTransactionsOnASingleAssetResponse
      {
        AssetTransactionList = getAssetTransactionsRequest.AssetTransactionList
      };
    }
  }
}