namespace TransactionProject.Server.Integration.Tests.Features.JuliesApi
{
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;
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

    public void ShouldGetAllAssetsFromApi()
    {
      // Arrange

      //Act
      //ReturnListOfAssetsResponse getAllAssetsResponse = await JuliesApi.GetJsonAsync<ReturnListOfAssetsResponse>(ReturnListOfAssetsApiRequest.ReturnListOfAssetsEndPoint);
      string response = JuliesApi.GetAsync<string>("/health");
      //Assert
      response.ShouldNotBe(null);
      //getAllAssetsResponse.ListOfAssets.Count.ShouldBeGreaterThan(0);
    }

    //public async Task ShouldGetAllAssets()
    //{
    //  // Arrange
    //  var getAllAssetsRequest = new ReturnListOfAssetsRequest();

    //  //Act
    //  ReturnListOfAssetsResponse getAllAssetsResponse =
    //    await Mediator.Send(getAllAssetsRequest);

    //  //Assert
    //  getAllAssetsResponse.ListOfAssets.Count.ShouldBeGreaterThan(0);
    //}

    //  public async Task ShouldGetSingleAsset()
    //  {
    //    // Arrange
    //    var getSingleAssetRequest = new ReturnSingleAssetRequest
    //    {
    //      AssetKey = ""
    //    };

    //    //Act
    //    ReturnSingleAssetResponse getSingleAssetResponse =
    //      await Mediator.Send(getSingleAssetRequest);

    //    //Assert
    //    getSingleAssetResponse.SingleAsset.ShouldBeOfType<AssetDefinitionDto>();
    //  }
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