namespace TransactionProject.Api.Features.Transactions
{
  using System;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Base;

  public class GetTransactionsApiResponse : BaseResponse
  {
    /// <summary>
    /// a default constructor is required for deserialization
    /// </summary>
    public GetTransactionsApiResponse() { }

    public List<TransactionsDto> ListOfTransactions { get; set; }
  }
}