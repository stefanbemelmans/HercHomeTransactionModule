namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetSingleTransactionHandler : IRequestHandler<ReturnSingleAssetTransactionRequest, ReturnSingleAssetTransactionResponse>
  {
    public JuliesApiHttpClient JuliesApi { get; set; }

    public ReturnSingleAssetSingleTransactionHandler(JuliesApiHttpClient aJuliesApi)
    {
      JuliesApi = aJuliesApi;
    }

    public async Task<ReturnSingleAssetTransactionResponse> Handle
      (
      ReturnSingleAssetTransactionRequest aReturnSingleAssetTransactionRequest,
      CancellationToken aCancellationToken
      )
    {
      SingleTransaction singleTransaction = await JuliesApi.SendJsonAsync<SingleTransaction>(
        HttpMethod.Get,
        ReturnSingleAssetTransactionApiRequest.ReturnSingleAssetTransactionEndpoint,
        new ReturnSingleAssetTransactionRequest
        {
          assetKey = aReturnSingleAssetTransactionRequest.assetKey,
          timestamp = aReturnSingleAssetTransactionRequest.timestamp
        }
        );

      return new ReturnSingleAssetTransactionResponse { SingleTransaction = singleTransaction };
    }
  }
}