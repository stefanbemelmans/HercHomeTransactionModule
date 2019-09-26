namespace TransactionProject.Client.Features.Transactions
{
  using BlazorState;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base;

  internal partial class TransactionState
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
        foreach(TransactionDto aDto in TransactionState.TransactionsToPay)
        {
          TransactionState._ListOfTransactions.Remove(aDto);
        }

        //TransactionState._TransactionsToPay = new List<TransactionDto>();
        return Unit.Task;
      }
    }
  }
}