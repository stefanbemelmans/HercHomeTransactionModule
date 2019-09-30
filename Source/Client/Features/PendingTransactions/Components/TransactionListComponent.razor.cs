namespace TransactionProject.Client.Features.PendingTransactions
{
  using BlazorState;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base.Components;
  using static TransactionProject.Client.Features.PendingTransactions.PendingTransactionState;

  public class TransactionListComponentBase : BaseComponent
  {
    
    protected override async Task OnInitializedAsync() =>
       await Mediator.Send(new FetchTransactionsAction());
  }
}