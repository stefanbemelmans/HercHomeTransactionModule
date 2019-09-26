namespace TransactionProject.Client.Features.Transactions
{
  using BlazorState;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base;
  using System.Collections.Generic;

  internal partial class TransactionState
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
        
        TransactionState._TransactionsToPay = new List<TransactionDto>();
        TransactionState._ListOfTransactions = new List<TransactionDto>();
        return Unit.Task;
      }
    }
  }
}