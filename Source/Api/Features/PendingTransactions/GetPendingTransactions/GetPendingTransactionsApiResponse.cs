namespace TransactionProject.Api.Features.PendingTransactions
{
  using System;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Base;

  public class GetPendingTransactionsApiResponse : BaseResponse
  {
    /// <summary>
    /// a default constructor is required for deserialization
    /// </summary>
    public GetPendingTransactionsApiResponse() { }

    public List<PendingTransactionDto> ListOfPendingTransactions { get; set; }
  }
}