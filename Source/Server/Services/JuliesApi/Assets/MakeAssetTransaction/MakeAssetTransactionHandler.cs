namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class MakeAssetTransactionHandler : IRequestHandler<MakeAssetTransactionRequest, MakeAssetTransactionResponse>
  {
    private MakeAssetTransactionHandler()
    { }

    public async Task<MakeAssetTransactionResponse> Handle
      (
      MakeAssetTransactionRequest aMakeAssetTransactionRequest,
      CancellationToken aCancellationToken
      )
    {
      var MakeAssetResponse = await JuliesApiHttpClient.PostJsonAsync<CreateAssetDefinitionResponse>(MakeAssetTransactionApiRequest.CreateAssetEndpoint + CreateAssetDefinitionApiRequest.ApiKey);
    }
  }
}