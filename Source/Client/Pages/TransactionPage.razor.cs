namespace TransactionProject.Client.Pages
{
  using System;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base.Components;
  using static TransactionProject.Client.Features.Transactions.TransactionState;

  public class TransactionPageBase : BaseComponent
  {
    public const string Route = "/transactions";

    //protected override async Task OnInitializedAsync() =>
    //   await Mediator.Send(new FetchTransactionsAction());
   
  }
}