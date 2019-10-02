namespace TransactionProject.Server.Integration.Tests.Features.PendingTransactions.GetAll
{
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.PendingTransactions;
  using TransactionProject.Server.Integration.Tests.Infrastructure;
  using TransactionProject.Server.Services.PendingTransactions;

  internal class GetPendingTransactionsTests
  {
    private readonly IMediator Mediator;
    private readonly IServiceProvider ServiceProvider;

    public GetPendingTransactionsTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    public async Task ShouldGetPendingTransactions()
    {
      // Arrange
      var getPendingTransactionsRequest = new GetPendingTransactionsRequest();

      //Act
      GetPendingTransactionsResponse getPendingTransactionsResponse =
        await Mediator.Send(getPendingTransactionsRequest);

      //Assert
      getPendingTransactionsResponse.ListOfPendingTransactions.Count.ShouldBe(10);
    }

    public async Task ShouldGetTransactionsFromServerFeatures()
    {
      // Arrange
      var getPendingTransactionsApiRequest = new GetPendingTransactionsApiRequest();

      //Act
      GetPendingTransactionsApiResponse getPendingTransactionsApiResponse =
        await Mediator.Send(getPendingTransactionsApiRequest);

      //Assert
      getPendingTransactionsApiResponse.ListOfPendingTransactions.Count.ShouldBe(10);
    }
  }
}