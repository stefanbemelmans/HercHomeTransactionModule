namespace TransactionProject.Server.Services.Transactions
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Transactions;

  public class GetTransactionsResponse
  {
    public GetTransactionsResponse()
    {
      ListOfTransactions = new List<TransactionDto>();
    }
    public List<TransactionDto> ListOfTransactions { get; set; }
  }
}