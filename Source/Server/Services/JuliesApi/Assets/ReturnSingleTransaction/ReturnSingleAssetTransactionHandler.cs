namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
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
      ReturnSingleAssetTransactionResponse aReturnSingleAssetResponse = await JuliesApi.GetJsonAsync<ReturnSingleAssetTransactionResponse>(ReturnSingleAssetTransactionApiRequest.Route);

      return new ReturnSingleAssetTransactionResponse { SingleTransaction = aReturnSingleAssetResponse.SingleTransaction };
    }
  }
}