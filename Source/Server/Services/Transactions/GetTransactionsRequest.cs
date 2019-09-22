namespace TransactionProject.Server.Services.Transactions
{
  using MediatR;

  public class GetTransactionsRequest : IRequest<GetTransactionsResponse>
    {
    public int NumberOfTransactions { get; set; } = 10;
  }
}
