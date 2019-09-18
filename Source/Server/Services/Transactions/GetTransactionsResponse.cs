namespace TransactionProject.Server.Services.Transactions
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Transactions;

  public class GetTransactionsResponse
  {
    public List<TransactionsDto> ListOfTransactions { get; set; }
  }
}