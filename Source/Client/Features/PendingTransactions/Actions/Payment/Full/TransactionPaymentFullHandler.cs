namespace TransactionProject.Client.Features.PendingTransactions
{
  using BlazorState;
  using MediatR;
  using System.Collections.Generic;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.PendingTransactions;
  using TransactionProject.Client.Features.Base;

  internal partial class PendingTransactionState
  {
    public class TransactionPaymentHandler : BaseHandler<TransactionPaymentFullAction>
    {
      public TransactionPaymentHandler(IStore aStore) : base(aStore) { }

      public override Task<Unit> Handle
      (
        TransactionPaymentFullAction aTransactionPaymentFullAction,
        CancellationToken aCancellationToken
      )
      {
        TransactionState._PendingTransactionsToPay = new List<PendingTransactionDto>();
        TransactionState._ListOfPendingTransactions = new List<PendingTransactionDto>();
        return Unit.Task;
      }
    }
  }
}