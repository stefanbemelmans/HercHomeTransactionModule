namespace TransactionProject.Api.Features.Transactions
{
  using System;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Base;

  public class GetTransactionsResponse : BaseResponse
  {
    /// <summary>
    /// a default constructor is required for deserialization
    /// </summary>
    public GetTransactionsResponse() { }

    public List<TransactionsDto> ListOfTransactions { get; set; }
  }
}