namespace TransactionProject.Server.Features.Transactions
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.Transactions;
  using TransactionProject.Server.Features.Transactions;
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
      var MockTransactionsResponse =  await Mediator.Send<GetTransactionsResponse>(new GetTransactionsRequest());
      
      var mockTransactionsList = new List<TransactionsDto>();
     
    }
  }
}