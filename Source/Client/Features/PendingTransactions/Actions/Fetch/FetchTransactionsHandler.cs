namespace TransactionProject.Client.Features.PendingTransactions
{
  using BlazorState;
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.PendingTransactions;
  using TransactionProject.Client.Features.Base;

  internal partial class PendingTransactionState
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
        FetchTransactionsAction aFetchTransactionsAction,
        CancellationToken aCancellationToken
      )
      {
        var getTransactionsApiRequest = new GetPendingTransactionsApiRequest { NumberOfTransactions = aFetchTransactionsAction.NumberOfTransactions };
        GetPendingTransactionsApiResponse getTransactionsApiResponse =
          await HttpClient.PostJsonAsync<GetPendingTransactionsApiResponse>(GetPendingTransactionsApiRequest.Route, getTransactionsApiRequest);
        TransactionState._ListOfPendingTransactions = getTransactionsApiResponse.ListOfPendingTransactions;
        return Unit.Value;
      }
    }
  }
}