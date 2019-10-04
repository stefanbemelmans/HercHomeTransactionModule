namespace TransactionProject.Server.Integration.Tests.Features.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Collections.Generic;
  using System.Net.Http;
  using System.Text.Json;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;
  using TransactionProject.Server.Integration.Tests.Infrastructure;
  using TransactionProject.Server.Services.JuliesApi;

  internal class ReturnTransactionsOnASingleAssetTests
  {
    private readonly JuliesApiHttpClient JuliesApi;
    private readonly IMediator Mediator;
    private readonly IServiceProvider ServiceProvider;

    public ReturnTransactionsOnASingleAssetTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      JuliesApi = ServiceProvider.GetService<JuliesApiHttpClient>();
    }

    public async Task ShouldGetAllTransactionsFromEndpoint()
    {
      // Arrange
      var getAllTransactionsRequest = new ReturnTransactionsOnASingleAssetRequest { AssetKey = "-LemR9cH3FEKwqhAHLLW" };
      //Act
      object response = await JuliesApi.SendJsonAsync<object>(HttpMethod.Get, ReturnTransactionsOnASingleAssetApiRequest.GetAssetTransactionsEndpoint, getAllTransactionsRequest);
      //Assert
      response.ShouldNotBe(null);
      string responseString = response.ToString();
      List<AssetTransactionDto> serializedListOfTransactions = JsonSerializer.Deserialize<List<AssetTransactionDto>>(responseString);
      serializedListOfTransactions.Count.ShouldBeGreaterThan(2);
    }

    public async Task ShouldGetAllTransactionsFromService()
    {
      // Arrange
      var getAllTransactionsRequest = new ReturnTransactionsOnASingleAssetRequest { AssetKey = "-LemR9cH3FEKwqhAHLLW" };
      //Act
      ReturnTransactionsOnASingleAssetResponse getListOfAssetTransactions =
        await Mediator.Send(getAllTransactionsRequest);

      //Assert
      getListOfAssetTransactions.AssetTransactionList.Count.ShouldBeGreaterThan(0);
    }

    public async Task ShouldSerializeAllTransactionsIntoTxType()
    {
      // Arrange
      var response = new ReturnTransactionsOnASingleAssetResponse();

      var getAllTransactionsRequest = new ReturnTransactionsOnASingleAssetRequest { AssetKey = "-LemR9cH3FEKwqhAHLLW" };
      //Act
      response = await JuliesApi.SendJsonAsync<ReturnTransactionsOnASingleAssetResponse>(HttpMethod.Get, ReturnTransactionsOnASingleAssetApiRequest.GetAssetTransactionsEndpoint, getAllTransactionsRequest);
      //Assert
      response.ShouldNotBe(null);
      response.AssetTransactionList.Count.ShouldBeGreaterThan(0);
    }

    public void ShouldTouchTheApi()
    {
      // Arrange
      string code = string.Empty;
      //Act
      //ReturnListOfAssetsResponse getAllAssetsResponse = await JuliesApi.GetJsonAsync<ReturnListOfAssetsResponse>(ReturnListOfAssetsApiRequest.ReturnListOfAssetsEndPoint);
      Task<System.Net.Http.HttpResponseMessage> responseTask = JuliesApi.GetAsync("/health");
      string continuation = responseTask.Result.StatusCode.ToString();
      //Assert
      continuation.ShouldBe("OK");      //getAllAssetsResponse.ListOfAssets.Count.ShouldBeGreaterThan(0);
    }

    //public async Task ShouldGetSingleAsset()
    //{
    //  // Arrange
    //  var getSingleAssetRequest = new ReturnSingleAssetRequest
    //  {
    //    AssetKey = "-LpAAEgyzH-3wInbcYCM"
    //  };

    //  //Act
    //  ReturnSingleAssetResponse getSingleAssetResponse =
    //    await Mediator.Send(getSingleAssetRequest);

    //  //Assert
    //  getSingleAssetResponse.SingleAsset.ShouldBeOfType<AssetDefinitionDto>();
    //  getSingleAssetResponse.SingleAsset.Transactions.Count.ShouldBeGreaterThan(0);
    //}
    //  public async Task ShouldGetAllAssetTransactions()
    //  {
    //    // Arrange
    //    var getAssetTransactionsRequest = new ReturnTransactionsOnASingleAssetRequest
    //    {
    //      AssetKey = ""
    //    };

    //    //Act
    //    ReturnTransactionsOnASingleAssetResponse getSingleAssetResponse =
    //      await Mediator.Send(getAssetTransactionsRequest);

    //    //Assert
    //    getSingleAssetResponse.AssetTransactionList.ShouldBeOfType<List<AssetTransactionDto>>();
    //  }

    //  public async Task ShouldGetSingleAssetTransaction()
    //  {
    //    // Arrange
    //    var getTransactionsRequest = new ReturnSingleAssetTransactionRequest
    //    {
    //      TransactionKey = ""
    //    };

    //    //Act
    //    ReturnSingleAssetTransactionResponse getSingleTransactionResponse =
    //      await Mediator.Send(getTransactionsRequest);

    //    //Assert
    //    getSingleTransactionResponse.SingleTransaction.ShouldBeOfType<AssetTransactionDto>();
    //  }
  }
}