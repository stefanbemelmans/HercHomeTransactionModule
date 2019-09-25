namespace TransactionProject.Server.Services.PendingTransactions
{
  using MediatR;

  public class GetPendingTransactionsRequest : IRequest<GetPendingTransactionsResponse>
    {
    public int NumberOfTransactions { get; set; } = 10;
  }
}
