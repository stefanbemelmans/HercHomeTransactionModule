namespace TransactionProject.Server.Services.PendingTransactions
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.PendingTransactions;

  public class GetPendingTransactionsResponse
  {
    public GetPendingTransactionsResponse()
    {
      ListOfPendingTransactions = new List<PendingTransactionDto>();
    }
    public List<PendingTransactionDto> ListOfPendingTransactions { get; set; }
  }
}