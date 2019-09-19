namespace TransactionProject.Server.Integration.Tests.Features.Transactions.GetAll
{
  using TransactionProject.Api.Features.Transactions;
  using TransactionProject.Server.Integration.Tests.Infrastructure;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;
  using TransactionProject.Server.Services.Transactions;

  internal class GetTransactionsTests
  {
    private readonly IMediator Mediator;
    private readonly IServiceProvider ServiceProvider;

    public GetTransactionsTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    public async Task ShouldGetTransactions()
    {
      // Arrange
      var getTransactionsRequest = new GetTransactionsRequest();

      //Act
      GetTransactionsResponse getTransactionsResponse =
        await Mediator.Send(getTransactionsRequest);

      //Assert
      getTransactionsResponse.ListOfTransactions.Count.ShouldBe(10);
    }

    public async Task ShouldGetTransactionsFromServerFeatures()
    {
      // Arrange
      var getTransactionsApiRequest = new GetTransactionsApiRequest();

      //Act
      GetTransactionsApiResponse getTransactionsApiResponse =
        await Mediator.Send(getTransactionsApiRequest);

      //Assert
      getTransactionsApiResponse.ListOfTransactions.Count.ShouldBe(10);
    }
  }
}