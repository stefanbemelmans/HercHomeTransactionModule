﻿namespace TransactionProject.Client.Features.PendingTransactions
{
  using BlazorState;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base;
  using TransactionProject.Api.Features.PendingTransactions;

  internal partial class PendingTransactionState
  {
    public class DeSelectTransactionHandler : BaseHandler<DeSelectTransactionAction>
    {
      public DeSelectTransactionHandler(IStore aStore) : base(aStore) { }

      public override Task<Unit> Handle
      (
        DeSelectTransactionAction aDeSelectTransactionAction,
        CancellationToken aCancellationToken
      )
      {
        PendingTransactionDto deSelectedTransaction = TransactionState._ListOfPendingTransactions.Find(aDto => aDto.TxId == aDeSelectTransactionAction.TxId);
        TransactionState._PendingTransactionsToPay.Remove(deSelectedTransaction);
        return Unit.Task;
      }
    }
  }
}