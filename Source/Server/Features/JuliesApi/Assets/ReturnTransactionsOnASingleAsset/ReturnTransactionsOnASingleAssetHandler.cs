namespace TransactionProject.Server.Features.JuliesApi
{
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnTransactionsOnASingleAssetHandler : IRequestHandler<ReturnTransactionsOnASingleAssetApiRequest, ReturnTransactionsOnASingleAssetApiResponse>
  {
    private IMediator Mediator { get; set; }

    public ReturnTransactionsOnASingleAssetHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<ReturnTransactionsOnASingleAssetApiResponse> Handle
      (
        ReturnTransactionsOnASingleAssetApiRequest aReturnTransactionsOfAnAssetRequest,
        CancellationToken aCancellationToken
      )
    {
      ReturnTransactionsOnASingleAssetApiResponse aReturnTransactionsOfAnAssetResponse = await Mediator.Send(new ReturnTransactionsOnASingleAssetApiRequest
      {
        AssetKey = aReturnTransactionsOfAnAssetRequest.AssetKey
      });

      return new ReturnTransactionsOnASingleAssetApiResponse
      {
        AssetTransactionList = aReturnTransactionsOfAnAssetResponse.AssetTransactionList
      };
    }
  }
}