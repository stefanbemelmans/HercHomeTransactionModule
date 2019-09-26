namespace TransactionProject.Client.Features.PendingTransactions
{
  using TransactionProject.Client.Features.Base;

  internal partial class TransactionState
  {
    public class DeSelectTransactionAction : BaseAction
    {
      public int TxId { get; set; }
    }
  }
}