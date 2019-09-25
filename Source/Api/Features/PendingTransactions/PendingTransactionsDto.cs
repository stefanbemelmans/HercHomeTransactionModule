namespace TransactionProject.Api.Features.PendingTransactions
{
  using System;

    public class PendingTransactionDto
  {
    public int Gas { get; set; }

    public string ToAddress { get; set; }

    public int TransactionAmount { get; set; }

    public DateTime TxDate { get; set; }

    public int TxId { get; set; }

    public PendingTransactionDto(DateTime aDateTime, int aTransactionAmount, int aGas, string aToAddress, int aTxId)
    {
      TxDate = aDateTime;
      TransactionAmount = aTransactionAmount;
      Gas = aGas;
      ToAddress = aToAddress;
      TxId = aTxId;
    }
  }
}