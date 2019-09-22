namespace TransactionProject.Client.Features.Transactions.Actions.Payment
{
  using BlazorState;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base;
  using TransactionProject.Api.Features.Transactions;

  internal partial class TransactionState
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
        TransactionDto deSelectedTransaction = TransactionState.ListOfTransactions.Find(aDto => aDto.TxId == aDeSelectTransactionAction.TxId);
        TransactionState.TransactionsToPay.Remove(deSelectedTransaction);
        return Unit.Task;
      }
    }
  }
}