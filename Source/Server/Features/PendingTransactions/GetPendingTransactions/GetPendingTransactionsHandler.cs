namespace TransactionProject.Server.Features.PendingTransactions
{
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.PendingTransactions;
  using TransactionProject.Server.Services.PendingTransactions;

  public class GetPendingTransactionsHandler : IRequestHandler<GetPendingTransactionsApiRequest, GetPendingTransactionsApiResponse>
  {
    private IMediator Mediator { get; set; }

    public GetPendingTransactionsHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<GetPendingTransactionsApiResponse> Handle
    (
      GetPendingTransactionsApiRequest aGetPendingTransactionsApiRequest,
      CancellationToken aCancellationToken
    )
    {
      var getTransRequest = new GetPendingTransactionsRequest() { NumberOfTransactions = 10 };

      GetPendingTransactionsResponse mockTransactionsResponse = await Mediator.Send(getTransRequest);

      return new GetPendingTransactionsApiResponse { ListOfPendingTransactions = mockTransactionsResponse.ListOfPendingTransactions };
    }
  }
}