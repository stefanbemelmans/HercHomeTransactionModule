namespace TransactionProject.Client.Features.Transactions.Components
{
  using System;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Transactions;
  using TransactionProject.Client.Features.Base.Components;

    public class TransactionListContainerBase : BaseComponent
  {
    IReadOnlyList<TransactionsDto> ListOfTransactions => TransactionState.ListOfTransactions;

    
    private uint TotalBalance { get; set; }
  }
}