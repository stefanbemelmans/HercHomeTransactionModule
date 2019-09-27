namespace TransactionProject.Client.Features.PendingTransactions
{
  using BlazorState;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.PendingTransactions;
  using TransactionProject.Client.Features.Base;

  internal partial class PendingTransactionState
  {
    public class SelectTransactionHandler : BaseHandler<SelectTransactionAction>
    {
      public SelectTransactionHandler(IStore aStore) : base(aStore) { }

      public override Task<Unit> Handle
      (
        SelectTransactionAction aSelectTransactionAction,
        CancellationToken aCancellationToken
      )
      {
        PendingTransactionDto selectedTransaction = TransactionState._ListOfPendingTransactions.Find(aDto => aDto.TxId == aSelectTransactionAction.TxId);
        TransactionState._PendingTransactionsToPay.Add(selectedTransaction);
        return Unit.Task;
      }
    }
  }
}