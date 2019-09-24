namespace TransactionProject.Server.Services.Transactions
{
  using MediatR;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.Transactions;

  public class GetTransactionsHandler : IRequestHandler<GetTransactionsRequest, GetTransactionsResponse>
  {
    //private HttpClient HttpClient { get; set; }

    //public GetTransactionsHandler(HttpClient aHttpClient)
    //{
    //  HttpClient = aHttpClient;
    //}

    public async Task<GetTransactionsResponse> Handle
         (
       GetTransactionsRequest aGetTransactionsRequest,
       CancellationToken aCancellationToken
     )
    {
      int numOfTransactions = aGetTransactionsRequest.NumberOfTransactions;
      var transactionResponse = new GetTransactionsResponse();
      var generatedTransactionList = new List<TransactionDto>();

      for (int aIndex = 1; aIndex <= numOfTransactions; aIndex++)
      {

        generatedTransactionList.Add

        (
           new TransactionDto
           (
             DateTime.Now, // TX date,
             (42 * aIndex) * 10, // Tx Amount,
             aIndex * 2, // Tx Gas,
             "0xs7s0030384a08642", // To Address
             aIndex // TxId
             )
         );
      };
      transactionResponse.ListOfTransactions = generatedTransactionList;

      return await Task.Run(() => transactionResponse);
    }
  }
}