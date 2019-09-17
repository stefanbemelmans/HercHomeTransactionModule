﻿namespace TransactionProject.Client.Features.Counter
{
  using BlazorState;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base;

  internal partial class CounterState
  {
    internal class IncrementCounterHandler : BaseHandler<IncrementCounterAction>
    {
      public IncrementCounterHandler(IStore aStore) : base(aStore) { }

      public override Task<Unit> Handle
      (
        IncrementCounterAction aIncrementCounterAction,
        CancellationToken aCancellationToken
      )
      {
        CounterState.Count += aIncrementCounterAction.Amount;
        return Unit.Task;
      }
    }
  }
}