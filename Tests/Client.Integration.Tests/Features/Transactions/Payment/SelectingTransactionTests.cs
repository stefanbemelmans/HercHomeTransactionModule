namespace TransactionProject.Client.Integration.Tests.Features.Transactions
{
  using BlazorState;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Transactions;
  using TransactionProject.Client.Integration.Tests.Infrastructure;
  using static TransactionProject.Client.Features.Transactions.Actions.Payment.TransactionState;
  using static TransactionProject.Client.Features.Transactions.TransactionState;

  internal class SelectTransactionTests
  {
    private readonly IMediator Mediator;
    private readonly IServiceProvider ServiceProvider;
    private readonly IStore Store;
    private TransactionState TransactionState => Store.GetState<TransactionState>();

    public SelectTransactionTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      Store = ServiceProvider.GetService<IStore>();
    }

    public async Task Should_AddSelectedTransactionToState()
    {
      // Arrange

      _ = await Mediator.Send(new FetchTransactionsAction());

      TransactionState.ListOfTransactions.Count.ShouldBe(10);

      // Act
      _ = await Mediator.Send(new SelectTransactionAction { TxId = 1 });

      // Assert
      TransactionState.TransactionsToPay.Count.ShouldBe(1);
    }

    public async Task Should_DeSelectTransactionFromPaymentList()
    {
      // Arrange
      _ = await Mediator.Send(new FetchTransactionsAction());

      TransactionState.ListOfTransactions.Count.ShouldBe(10);

      _ = await Mediator.Send(new SelectTransactionAction { TxId = 1 });

      TransactionState.TransactionsToPay.Count.ShouldBe(1);

      var deselectRequest = new DeSelectTransactionAction { TxId = 1 };
      // Act
      _ = await Mediator.Send(deselectRequest);

      // Assert
      TransactionState.TransactionsToPay.Count.ShouldBe(0);
    }
  }
}