﻿namespace TransactionProject.Server.Integration.Tests.Features.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;
  using TransactionProject.Server.Integration.Tests.Infrastructure;
  using TransactionProject.Server.Services.JuliesApi;

  internal class GetAllAssetsTests
  {
    private readonly JuliesApiHttpClient JuliesApi;
    private readonly IMediator Mediator;
    private readonly IServiceProvider ServiceProvider;

    public GetAllAssetsTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      JuliesApi = ServiceProvider.GetService<JuliesApiHttpClient>();
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

    public async Task ShouldTouchAssetListEndpoint()
    {
      // Arrange

      //Act
      object response = await JuliesApi.GetAsync(ReturnListOfAssetsApiRequest.ReturnListOfAssetsEndPoint);
      //Assert
      response.ShouldNotBe(null);
    }


    public async Task ShouldGetAssetListFromHttpEndpoint()
    {
      // Arrange

      //Act
      object response = await JuliesApi.GetJsonAsync<object>(ReturnListOfAssetsApiRequest.ReturnListOfAssetsEndPoint);
      //Assert
      response.ShouldNotBe(null);
     
    }


    public async Task ShouldGetListOfAssetFromService()
    {
      // Arrange
      var returnListOfAssetsRequest = new ReturnListOfAssetsRequest();
      //Act
      ReturnListOfAssetsResponse getListOfAssetsResponse =
        await Mediator.Send(returnListOfAssetsRequest);

      //Assert
      getListOfAssetsResponse.AssetList.Count.ShouldBeGreaterThan(0);
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