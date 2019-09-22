namespace TransactionProject.Api.Features.Transactions
{
  using System;

  /// <summary>
  /// The object that is passed back and forth from the Server to the client.
  /// </summary>
  /// <remarks>TODO: This should be an immutable class
  /// but serialization doesn't work with no setter or private setter yet</remarks>
  public class TransactionDto
  {
    public int Gas { get; set; }

    public string ToAddress { get; set; }

    public int TransactionAmount { get; set; }

    public DateTime TxDate { get; set; }

    public int TxId { get; set; }

    public TransactionDto() { }

    public TransactionDto(DateTime aDateTime, int aTransactionAmount, int aGas, string aToAddress, int aTxId)
    {
      TxDate = aDateTime;
      TransactionAmount = aTransactionAmount;
      Gas = aGas;
      ToAddress = aToAddress;
      TxId = aTxId;
    }
  }
}