namespace TransactionProject.Client.Features.PendingTransactions.Components
{
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base.Components;
  using static TransactionProject.Client.Features.PendingTransactions.TransactionState;

  public class TransactionListComponentBase : BaseComponent
  {
    protected override async Task OnInitializedAsync() =>
       await Mediator.Send(new FetchTransactionsAction());
  }
}