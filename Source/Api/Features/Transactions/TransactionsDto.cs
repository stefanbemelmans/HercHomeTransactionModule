namespace TransactionProject.Api.Features.Transactions
{
  using System;
  using System.Numerics;

  /// <summary>
  /// The object that is passed back and forth from the Server to the client.
  /// </summary>
  /// <remarks>TODO: This should be an immutable class
  /// but serialization doesn't work with no setter or private setter yet</remarks>
  public class TransactionsDto
  {
    public double Gas { get; set; }

    public string ToAddress { get; set; }

    public BigInteger TransactionAmount { get; set; }

    public DateTime TransactionDate { get; set; }

    public int TxId { get; set; }

    public TransactionsDto(DateTime aDateTime, BigInteger aTransactionAmount, double aGas, string aToAddress, int aTxId)
    {
      TransactionDate = aDateTime;
      TransactionAmount = aTransactionAmount;
      Gas = aGas;
      ToAddress = aToAddress;
      TxId = aTxId;
    }
  }
}