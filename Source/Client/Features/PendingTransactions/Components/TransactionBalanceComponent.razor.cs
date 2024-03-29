﻿namespace TransactionProject.Client.Features.PendingTransactions.Components
{
  using System.Collections.Generic;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.PendingTransactions;
  using TransactionProject.Client.Features.Base.Components;
  using static TransactionProject.Client.Features.PendingTransactions.PendingTransactionState;

  public class TransactionBalanceComponentBase : BaseComponent
  {
    public int TotalBalance => PendingTransactionState.TotalBalance;
    public int TotalCount => PendingTransactionState.TransactionsToPay.Count;
    public IReadOnlyList<PendingTransactionDto> TransactionsToPay => PendingTransactionState.TransactionsToPay;


    public async Task PayAll() => _ = await Mediator.Send(new TransactionPaymentFullAction());
    public async Task PaySelected() => _ = await Mediator.Send(new TransactionPaymentPartialAction());
  }
}