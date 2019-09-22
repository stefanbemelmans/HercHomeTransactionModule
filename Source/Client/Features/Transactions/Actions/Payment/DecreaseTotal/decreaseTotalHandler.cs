namespace TransactionProject.Client.Features.Transactions.Actions.Payment
{
  using BlazorState;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base;

  internal partial class TransactionState
  {
    public class DecreaseTotalHandler : BaseHandler<DecreaseTotalAction>
    {
      public DecreaseTotalHandler(IStore aStore) : base(aStore) { }

      public override Task<Unit> Handle
      (
        DecreaseTotalAction aDecreaseTotalAction,
        CancellationToken aCancellationToken
      )
      {
        TransactionState.TotalBalance -= aDecreaseTotalAction.Amount;
        return Unit.Task;
      }
    }
  }
}