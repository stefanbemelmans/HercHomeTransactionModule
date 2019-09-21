using BlazorState;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TransactionProject.Client.Features.Base;

namespace TransactionProject.Client.Features.Transactions.Actions.Payment.IncreaseTotal
{
  internal partial class TransactionState
  {
    public class IncreaseTotalHandler : BaseHandler<IncreaseTotalAction>
    {
      public IncreaseTotalHandler(IStore aStore) : base(aStore) { }

      public override Task<Unit> Handle
      (
        IncreaseTotalAction aIncreaseTotalAction,
        CancellationToken aCancellationToken
      )
      {
        TransactionState.TotalBalance += aIncreaseTotalAction.Amount;
        return Unit.Task;
      }
    }
  }
}