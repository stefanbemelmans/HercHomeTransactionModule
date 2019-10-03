namespace TransactionProject.Server.Features.JuliesApi
{
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class MakeAssetTransactionHandler : IRequestHandler<MakeAssetTransactionApiRequest, MakeAssetTransactionApiResponse>
  {
    private IMediator Mediator { get; set; }

    public MakeAssetTransactionHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<MakeAssetTransactionApiResponse> Handle
      (
        MakeAssetTransactionApiRequest aCreateTransactionRequest,
        CancellationToken aCancellationToken
      )
    {
      MakeAssetTransactionApiResponse createTransactionResponse = await Mediator.Send(new MakeAssetTransactionApiRequest
      {
        MakeAssetTransactionDto = aCreateTransactionRequest.MakeAssetTransactionDto
      });

      return new MakeAssetTransactionApiResponse
      {
        TransactionKey = createTransactionResponse.TransactionKey
      };
    }
  }
}