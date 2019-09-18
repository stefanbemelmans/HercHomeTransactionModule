namespace TransactionProject.Client.Features.Transactions.Components
{
  using System;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Transactions;
  using TransactionProject.Client.Features.Base.Components;

    public class TransactionListContainerBase : BaseComponent
  {
    IReadOnlyList<TransactionsDto> ListOfTransactions => TransactionState.ListOfTransactions;

    private bool HasPaid { get; set; } = false;
    private uint TotalBalance { get; set; }
  }
}