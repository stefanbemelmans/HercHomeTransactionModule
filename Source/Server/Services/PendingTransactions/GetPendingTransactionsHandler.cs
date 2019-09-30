namespace TransactionProject.Server.Services.PendingTransactions
{
  using MediatR;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.PendingTransactions;

  public class GetPendingTransactionsHandler : IRequestHandler<GetPendingTransactionsRequest, GetPendingTransactionsResponse>
  {
    //private HttpClient HttpClient { get; set; }

    //public GetTransactionsHandler(HttpClient aHttpClient)
    //{
    //  HttpClient = aHttpClient;
    //}

    public async Task<GetPendingTransactionsResponse> Handle
         (
       GetPendingTransactionsRequest aGetPendingTransactionsRequest,
       CancellationToken aCancellationToken
     )
    {
      int numOfTransactions = aGetPendingTransactionsRequest.NumberOfTransactions;
      var transactionResponse = new GetPendingTransactionsResponse();
      var generatedTransactionList = new List<PendingTransactionDto>();

      for (int aIndex = 1; aIndex <= numOfTransactions; aIndex++)
      {

        generatedTransactionList.Add

        (
           new PendingTransactionDto
           (
             DateTime.Now, // TX date,
             (42 * aIndex) * 10, // Tx Amount,
             aIndex * 2, // Tx Gas,
             "0xs7s0030384a08642", // To Address
             aIndex // TxId
             )
         );
      };
      transactionResponse.ListOfPendingTransactions = generatedTransactionList;

      return await Task.Run(() => transactionResponse);
    }
  }
}