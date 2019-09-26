namespace TransactionProject.Client.Features.Base
{
  using BlazorState;
  using TransactionProject.Client.Features.Application;
  using TransactionProject.Client.Features.Counter;
  using TransactionProject.Client.Features.EventStream;
  using TransactionProject.Client.Features.PendingTransactions;
  using TransactionProject.Client.Features.WeatherForecast;

  /// <summary>
  /// Base Handler that makes it easy to access state
  /// </summary>
  /// <typeparam name="TAction"></typeparam>
  internal abstract class BaseHandler<TAction> : ActionHandler<TAction>
    where TAction : IAction
  {
    protected ApplicationState ApplicationState => Store.GetState<ApplicationState>();

    protected CounterState CounterState => Store.GetState<CounterState>();

    protected EventStreamState EventStreamState => Store.GetState<EventStreamState>();

    protected TransactionState TransactionState => Store.GetState<TransactionState>();

    protected WeatherForecastsState WeatherForecastsState => Store.GetState<WeatherForecastsState>();

    public BaseHandler(IStore aStore) : base(aStore) { }
  }
}