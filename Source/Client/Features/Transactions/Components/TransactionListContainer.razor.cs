namespace TransactionProject.Client.Features.Transactions.Components
{
  using System.Collections.Generic;
  using TransactionProject.Client.Features.Base.Components;
  using TransactionProject.Api.Features.Transactions;
  public class TransactionListContainerBase : BaseComponent
    {
    public IReadOnlyList<TransactionsDto> ListOfTransactions => TransactionState.ListOfTransactions;
    }
}
