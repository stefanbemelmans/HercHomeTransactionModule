namespace TransactionProject.Server.Features.Transactions
{
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.Transactions;
  using MediatR;
  using TransactionProject.Server.Services.Transactions;

  public class GetTransactionsHandler : IRequestHandler<GetTransactionsApiRequest, GetTransactionsApiResponse>
  {
    IMediator Mediator { get; set; }

    public GetTransactionsHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<GetTransactionsApiResponse> Handle
    (
      GetTransactionsApiRequest aGetTransactionsApiRequest,
      CancellationToken aCancellationToken
    )
    {
      var getTransRequest = new GetTransactionsRequest() { NumberOfTransactions = aGetTransactionsApiRequest.NumberOfTransactions };

      GetTransactionsResponse mockTransactionsResponse = await Mediator.Send(getTransRequest);

      return new GetTransactionsApiResponse { ListOfTransactions = mockTransactionsResponse.ListOfTransactions };
     
    }
  }
}