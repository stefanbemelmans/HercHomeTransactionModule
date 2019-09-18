namespace TransactionProject.Server.Services.Transactions
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.Transactions;

  public class GetTransactionsHandler
  {
    private HttpClient HttpClient { get; set; }

    public GetTransactionsHandler(HttpClient aHttpClient)
    {
      HttpClient = aHttpClient;
    }

    public async Task<GetTransactionsResponse> Handle
         (
       GetTransactionsRequest aGetTransactionsRequest,
       CancellationToken aCancellationToken
     )
    {
      int numOfTransactions = aGetTransactionsRequest.NumberOfTransactions;
      var transactionResponse = new GetTransactionsResponse();
      var generatedTransactionList = new List<TransactionsDto>();

      Enumerable.Range(1, numOfTransactions).ToList().ForEach
     (
       aIndex => transactionResponse.ListOfTransactions.Add

       (
          new TransactionsDto
          (
            DateTime.Now.AddDays(aIndex),
            342 * (aIndex * 100),
            .0000000194887342,
            "0xs7s0030384a08642"
          )
        )
      );

      return await Task.Run(() => transactionResponse);
    }
  }
}