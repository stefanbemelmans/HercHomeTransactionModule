namespace TransactionProject.Client.Features.Transactions
{
  using TransactionProject.Client.Features.Base;

  internal partial class TransactionState
  {
    public class FetchTransactionsAction : BaseAction 
    {
      public string UserName { get; set; }
    }

  }
}