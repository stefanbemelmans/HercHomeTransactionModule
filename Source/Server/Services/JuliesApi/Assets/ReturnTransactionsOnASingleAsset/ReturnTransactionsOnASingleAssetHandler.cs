namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;
  using System.Net.Http;
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
       Dictionary<string, Transaction> assetTransactionList = await JuliesApi.SendJsonAsync<Dictionary<string,Transaction>>(HttpMethod.Get, ReturnTransactionsOnASingleAssetApiRequest.GetAssetTransactionsEndpoint, new ReturnTransactionsOnASingleAssetRequest
      {
        AssetKey = aReturnTransactionsOnASingleAssetRequest.AssetKey
      });
      
      return new ReturnTransactionsOnASingleAssetResponse
      {
        AssetTransactionList = assetTransactionList
      };
    }
  }
}