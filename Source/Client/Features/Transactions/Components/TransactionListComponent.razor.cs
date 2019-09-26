namespace TransactionProject.Client.Features.Transactions.Components
{
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base.Components;
  using static TransactionProject.Client.Features.Transactions.TransactionState;

  public class TransactionListComponentBase : BaseComponent
  {
    protected override async Task OnInitializedAsync() =>
       await Mediator.Send(new FetchTransactionsAction());
  }
}