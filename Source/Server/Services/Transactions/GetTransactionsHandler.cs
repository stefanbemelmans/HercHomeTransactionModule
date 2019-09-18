namespace TransactionProject.Server.Services.Transactions
{
  using MediatR;

  public class GetTransactionsHandler
    {
    IMediator Mediator { get; set; }

    public GetTransactionsHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }
  }
}
