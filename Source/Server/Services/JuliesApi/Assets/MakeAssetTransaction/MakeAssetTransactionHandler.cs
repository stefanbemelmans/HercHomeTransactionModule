namespace TransactionProject.Server.Services.JuliesApi.Assets.MakeAssetTransaction
{
  using MediatR;
  using System.Threading;

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
      var MakeAssetResponse = await JuliesApiHttpClient.PostJsonAsync<CreateAssetDefinitionResponse>(MakeAssetTransactionRequest. + CreateAssetDefinitionApiRequest.ApiKey);
    }
  }
}