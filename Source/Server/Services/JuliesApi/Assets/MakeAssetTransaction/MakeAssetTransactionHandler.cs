namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class MakeAssetTransactionHandler : IRequestHandler<MakeAssetTransactionRequest, MakeAssetTransactionResponse>
  {
    public JuliesApiHttpClient JuliesApi { get; set; }

    public MakeAssetTransactionHandler(JuliesApiHttpClient aJuliesApi)
    {
      JuliesApi = aJuliesApi;
    }

    public async Task<MakeAssetTransactionResponse> Handle
      (
      MakeAssetTransactionRequest aMakeAssetTransactionRequest,
      CancellationToken aCancellationToken
      )
    {
      MakeAssetTransactionResponse makeAssetResponse = await JuliesApi.PostJsonAsync<MakeAssetTransactionResponse>(MakeAssetTransactionApiRequest.MakeTransactionEndpoint, new MakeAssetTransactionRequest
      {
       AssetTransaction = aMakeAssetTransactionRequest.AssetTransaction
      });
      return new MakeAssetTransactionResponse
      {
        TransactionKey = makeAssetResponse.TransactionKey
      };
    }
  }
}