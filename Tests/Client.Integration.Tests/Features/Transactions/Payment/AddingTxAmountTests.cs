namespace TransactionProject.Client.Integration.Tests.Features.PendingTransactions
{
  using TransactionProject.Client.Integration.Tests.Infrastructure;
  using BlazorState;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Transactions;
  using TransactionProject.Client.Features.PendingTransactions;

  internal class AddingTxAmountTests
  {
    private readonly IMediator Mediator;
    private readonly IServiceProvider ServiceProvider;
    private readonly IStore Store;
    private TransactionState TransactionState => Store.GetState<TransactionState>();
    public AddingTxAmountTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      Store = ServiceProvider.GetService<IStore>();
    }

    public async Task Should_IncreaseTotalInState()
    {
      // Arrange 
      var increaseRequest = new IncreaseTotalAction { Amount = 200 };
      // Act
      _ = await Mediator.Send(increaseRequest);
      
      // Assert
      TransactionState.TotalBalance.ShouldBe(200);
    }

    public async Task Should_DecreaseTotalInState()
    {
      // Arrange 
      var decreaseRequest = new DecreaseTotalAction { Amount = 200 };
      // Act
      _ = await Mediator.Send(decreaseRequest);

      // Assert
      TransactionState.TotalBalance.ShouldBe(-200);
    }


  }
}