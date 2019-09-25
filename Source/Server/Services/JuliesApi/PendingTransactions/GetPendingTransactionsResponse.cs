namespace TransactionProject.Server.Services.PendingTransactions
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.PendingTransactions;

  public class GetPendingTransactionsResponse
  {
    public GetPendingTransactionsResponse()
    {
      ListOfTransactions = new List<PendingTransactionDto>();
    }
    public List<PendingTransactionDto> ListOfTransactions { get; set; }
  }
}