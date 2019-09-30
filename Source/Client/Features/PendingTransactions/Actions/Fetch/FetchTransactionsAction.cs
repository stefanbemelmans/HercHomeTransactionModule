namespace TransactionProject.Client.Features.PendingTransactions
{
  using TransactionProject.Client.Features.Base;

  internal partial class PendingTransactionState
  {
    public class FetchTransactionsAction : BaseAction 
    {
      // Just in case we need a user name
      //public string UserName { get; set; }
      public int NumberOfTransactions { get; set; } = 10;
    }

  }
}