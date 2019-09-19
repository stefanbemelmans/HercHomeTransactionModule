namespace TransactionProject.Server.Services.Transactions
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Transactions;

  public class GetTransactionsResponse
  {
    public GetTransactionsResponse()
    {
      ListOfTransactions = new List<TransactionsDto>();
    }
    public List<TransactionsDto> ListOfTransactions { get; set; }
  }
}