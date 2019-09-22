namespace TransactionProject.Client.Features.Transactions.Components
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Transactions;
  using TransactionProject.Client.Features.Base.Components;

  public class TransactionBalanceComponentBase : BaseComponent
  {
    public int TotalBalance => TransactionState.TotalBalance;
    public int TotalCount => TransactionState.TransactionsToPay.Count;
    public IReadOnlyList<TransactionDto> TransactionsToPay => TransactionState.TransactionsToPay;
  }
}