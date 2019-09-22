namespace TransactionProject.Client.Features.Transactions.Actions.Payment
{
  using TransactionProject.Client.Features.Base;

  internal partial class TransactionState
  {
    public class IncreaseTotalAction : BaseAction
    {
      public int Amount { get; set; }
    }
  }
}
