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
    public class SelectTransactionHandler : BaseHandler<SelectTransactionAction>
    {
      public SelectTransactionHandler(IStore aStore) : base(aStore) { }

      public override Task<Unit> Handle
      (
        SelectTransactionAction aSelectTransactionAction,
        CancellationToken aCancellationToken
      )
      {
        TransactionDto selectedTransaction = TransactionState.ListOfTransactions.Find(aDto => aDto.TxId == aSelectTransactionAction.TxId);
        TransactionState.TransactionsToPay.Add(selectedTransaction);
        return Unit.Task;
      }
    }
  }
}