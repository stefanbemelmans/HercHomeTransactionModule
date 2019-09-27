namespace TransactionProject.Client.Features.PendingTransactions
{
  using TransactionProject.Client.Features.Base;

  internal partial class PendingTransactionState
  {
    public class DeSelectTransactionAction : BaseAction
    {
      public int TxId { get; set; }
    }
  }
}