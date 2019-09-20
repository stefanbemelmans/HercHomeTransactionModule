namespace TransactionProject.Client.Integration.Tests.Features.Transactions
{
  using TransactionProject.Client.Features.Transactions;
  using TransactionProject.Client.Integration.Tests.Infrastructure;
  using BlazorState;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;
  using static TransactionProject.Client.Features.Transactions.TransactionState;

  internal class FetchTransactionsTests
  {
    private readonly IMediator Mediator;
    private readonly IServiceProvider ServiceProvider;
    private readonly IStore Store;
    private TransactionState TransactionState => Store.GetState<TransactionState>();

    public FetchTransactionsTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      Store = ServiceProvider.GetService<IStore>();
    }

    public async Task Should_Fetch_Transactionss()
    {
      var fetchTransactionssRequest = new FetchTransactionsAction();

      _ = await Mediator.Send(fetchTransactionssRequest);

      TransactionState.ListOfTransactions.Count.ShouldBeGreaterThan(0);
    }
  }
}