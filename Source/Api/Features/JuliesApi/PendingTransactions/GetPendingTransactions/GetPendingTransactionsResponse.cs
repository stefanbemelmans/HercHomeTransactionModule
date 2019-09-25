namespace TransactionProject.Api.Features.PendingTransactions
{
  using System;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Base;

  public class GetPendingTransactionsResponse : BaseResponse
  {
    /// <summary>
    /// a default constructor is required for deserialization
    /// </summary>
    public GetPendingTransactionsResponse() { }

    public List<PendingTransactionDto> ListOfPendingTransactions { get; set; }
  }
}