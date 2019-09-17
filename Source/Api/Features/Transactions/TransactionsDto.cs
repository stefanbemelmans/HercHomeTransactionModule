namespace TransactionProject.Api.Features.Transactions
{
  using System;
  /// <summary>
  /// The object that is passed back and forth from the Server to the client.
  /// </summary>
  /// <remarks>TODO: This should be an immutable class 
  /// but serialization doesn't work with no setter or private setter yet</remarks>
  public class TransactionsDto
  {
    public TransactionsDto() { }
        
    public DateTime TransactionDate { get; set; }
    public string TransactionAmount { get; set; }
    public string ToAddress { get; set; }
    
  }
}