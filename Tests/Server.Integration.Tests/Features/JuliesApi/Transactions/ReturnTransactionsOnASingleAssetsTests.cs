﻿namespace TransactionProject.Server.Integration.Tests.Features.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using Microsoft.Extensions.DependencyInjection;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Linq;
  using Shouldly;
  using System;
  using System.Collections.Generic;
  using System.Net.Http;
  using System.Text.Json;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;
  using TransactionProject.Server.Integration.Tests.Infrastructure;
  using TransactionProject.Server.Services.JuliesApi;
  using TypeSupport.Extensions;

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
      //object response = await JuliesApi.SendJsonAsync<object>(HttpMethod.Get, ReturnTransactionsOnASingleAssetApiRequest.GetAssetTransactionsEndpoint, getAllTransactionsRequest);
      List<AssetTransactionDto> response = await JuliesApi.SendJsonAsync<List<AssetTransactionDto>>(HttpMethod.Get, ReturnTransactionsOnASingleAssetApiRequest.GetAssetTransactionsEndpoint, getAllTransactionsRequest);
      //Assert
      response.ShouldNotBe(null);

      response.Count.ShouldBeGreaterThan(2);
    }

    //public async Task ShouldGetAllTransactionsFromService()
    //{
    //  // Arrange
    //  var getAllTransactionsRequest = new ReturnTransactionsOnASingleAssetRequest { AssetKey = "-LemR9cH3FEKwqhAHLLW" };
    //  //Act
    //  ReturnTransactionsOnASingleAssetResponse getListOfAssetTransactions =
    //    await Mediator.Send(getAllTransactionsRequest);

    //  //Assert
    //  getListOfAssetTransactions.AssetTransactionList.Count.ShouldBeGreaterThan(0);
    //}

    //public async Task ShouldSerializeAllTransactionsIntoTxType()
    //{
    //  // Arrange
    //  var response = new ReturnTransactionsOnASingleAssetResponse();

    //  var getAllTransactionsRequest = new ReturnTransactionsOnASingleAssetRequest { AssetKey = "-LemR9cH3FEKwqhAHLLW" };
    //  //Act
    //  response = await JuliesApi.SendJsonAsync<ReturnTransactionsOnASingleAssetResponse>(HttpMethod.Get, ReturnTransactionsOnASingleAssetApiRequest.GetAssetTransactionsEndpoint, getAllTransactionsRequest);
    //  //Assert
    //  response.ShouldNotBe(null);
    //  response.AssetTransactionList.Count.ShouldBeGreaterThan(0);
    //}

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
    public async Task ShouldGetSingleAssetTransactionFromEndpoint()
    {
      // Arrange
      var getSingleTransactionsRequest = new ReturnSingleAssetTransactionRequest
      {
        assetKey = "-LeFCweEsr2wZvEsWGkY",
        timestamp = 1557675299267
      };

      //Act
      Transaction singleTransaction = await JuliesApi.SendJsonAsync<Transaction>(HttpMethod.Get, ReturnSingleAssetTransactionApiRequest.ReturnSingleAssetTransactionEndpoint, getSingleTransactionsRequest);

      //Assert
      singleTransaction.ShouldNotBeNull();
      singleTransaction.Header.AssetId.ShouldNotBeNull();

    }
    public async Task ShouldGetSingleTransactionFromService()
    {
      // Arrange
      var getSingleTransactionsRequest = new ReturnSingleAssetTransactionRequest
      {
        assetKey = "-LeFCweEsr2wZvEsWGkY",
        timestamp = 1557675299267
      };

      //Act
      ReturnSingleAssetTransactionResponse getSingleTransactionResponse =
        await Mediator.Send(getSingleTransactionsRequest);

      //Assert
      getSingleTransactionResponse.SingleTransaction.ShouldBeOfType<Transaction>();
      getSingleTransactionResponse.SingleTransaction.Header.AssetId.ShouldNotBeNull();
    }


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

    // 
  }
}