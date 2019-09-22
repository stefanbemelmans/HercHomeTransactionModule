namespace TransactionProject.Client.Features.Transactions
{
  using TransactionProject.Client.Features.Base;

  internal partial class TransactionState
  {
    public class FetchTransactionsAction : BaseAction 
    {
      // Just in case we need a user name
      //public string UserName { get; set; }
      public int NumberOfTransactions { get; set; } = 10;
    }

  }
}