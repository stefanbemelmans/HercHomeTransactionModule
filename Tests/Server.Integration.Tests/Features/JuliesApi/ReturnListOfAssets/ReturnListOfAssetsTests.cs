namespace TransactionProject.Server.Integration.Tests.Features.JuliesApi
{
  using TransactionProject.Server.Integration.Tests.Infrastructure;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;
  using TransactionProject.Server.Services.JuliesApi;
  using TransactionProject.Api.Features.JuliesApi;
  using System.Collections.Generic;

  internal class GetAllAssetsTests
  {
    private readonly IMediator Mediator;
    private readonly IServiceProvider ServiceProvider;

    public GetAllAssetsTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    public async Task ShouldGetAllAssets()
    {
      // Arrange
      var getAllAssetsRequest = new ReturnListOfAssetsRequest();

      //Act
      ReturnListOfAssetsResponse getAllAssetsResponse =
        await Mediator.Send(getAllAssetsRequest);

      //Assert
      getAllAssetsResponse.ListOfAssets.Count.ShouldBeGreaterThan(0);
    }

    public async Task ShouldGetSingleAsset()
    {
      // Arrange
      var getSingleAssetRequest = new ReturnSingleAssetRequest
      {
        AssetKey = ""
      };

      //Act
      ReturnSingleAssetResponse getSingleAssetResponse =
        await Mediator.Send(getSingleAssetRequest);

      //Assert
      getSingleAssetResponse.SingleAsset.ShouldBeOfType<AssetDefinitionDto>();
    }
    public async Task ShouldGetAllAssetTransactions()
    {
      // Arrange
      var getAssetTransactionsRequest = new ReturnTransactionsOnASingleAssetRequest
      {
        AssetKey = ""
      };

      //Act
      ReturnTransactionsOnASingleAssetResponse getSingleAssetResponse =
        await Mediator.Send(getAssetTransactionsRequest);

      //Assert
      getSingleAssetResponse.AssetTransactionList.ShouldBeOfType<List<AssetTransactionDto>>();
    }

    public async Task ShouldGetSingleAssetTransaction()
    {
      // Arrange
      var getTransactionsRequest = new ReturnSingleAssetTransactionRequest
      {
        TransactionKey = ""
      };

      //Act
      ReturnSingleAssetTransactionResponse getSingleTransactionResponse =
        await Mediator.Send(getTransactionsRequest);

      //Assert
      getSingleTransactionResponse.SingleTransaction.ShouldBeOfType<AssetTransactionDto>();
    }
  }
} 
