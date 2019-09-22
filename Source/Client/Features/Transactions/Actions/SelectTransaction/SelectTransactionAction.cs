namespace TransactionProject.Client.Features.Transactions
{
  using TransactionProject.Client.Features.Base;

  internal partial class TransactionState
  {
    public class SelectTransactionAction : BaseAction
    {
      public int TxId { get; set; }
    }
  }
}