namespace TransactionProject.Client.Features.Transactions
{
  using BlazorState;
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.Transactions;
  using TransactionProject.Client.Features.Base;

  internal partial class TransactionState
  {
    public class FetchTransactionsHandler : BaseHandler<FetchTransactionsAction>
    {
      private readonly HttpClient HttpClient;

      public FetchTransactionsHandler(IStore aStore, HttpClient aHttpClient) : base(aStore)
      {
        HttpClient = aHttpClient;
      }

      public override async Task<Unit> Handle
      (
        FetchTransactionsAction aFetcTransactionsAction,
        CancellationToken aCancellationToken
      )
      {
        var getTransactionsApiRequest = new GetTransactionsApiRequest { NumberOfTransactions = aFetcTransactionsAction.NumberOfTransactions };
        GetTransactionsApiResponse getTransactionsApiResponse =
          await HttpClient.PostJsonAsync<GetTransactionsApiResponse>(GetTransactionsApiRequest.Route, getTransactionsApiRequest);
        TransactionState._ListOfTransactions = getTransactionsApiResponse.ListOfTransactions;
        return Unit.Value;
      }
    }
  }
}