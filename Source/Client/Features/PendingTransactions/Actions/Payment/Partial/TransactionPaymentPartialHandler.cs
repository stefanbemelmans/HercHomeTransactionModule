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
    public class TransactionPaymentPartialHandler : BaseHandler<TransactionPaymentPartialAction>
    {
      public TransactionPaymentPartialHandler(IStore aStore) : base(aStore) { }

      public override Task<Unit> Handle
      (
        TransactionPaymentPartialAction aTransactionPaymentAction,
        CancellationToken aCancellationToken
      )
      {
        foreach(PendingTransactionDto aDto in TransactionState.TransactionsToPay)
        {
          TransactionState._ListOfPendingTransactions.Remove(aDto);
        }

        //TransactionState._TransactionsToPay = new List<TransactionDto>();
        return Unit.Task;
      }
    }
  }
}