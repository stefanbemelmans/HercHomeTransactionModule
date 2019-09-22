namespace TransactionProject.Client.Features.Transactions.Components
{
  using System.Collections.Generic;
  using TransactionProject.Client.Features.Base.Components;
  using TransactionProject.Api.Features.Transactions;
  using static TransactionProject.Client.Features.Transactions.TransactionState;
  using System.Threading.Tasks;

  public class TransactionListComponentBase : BaseComponent
  {
    protected override async Task OnInitializedAsync() =>
       await Mediator.Send(new FetchTransactionsAction());
  }
}
