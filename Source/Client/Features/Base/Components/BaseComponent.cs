namespace TransactionProject.Client.Features.Base.Components
{
  using BlazorState.Pipeline.ReduxDevTools;
  using TransactionProject.Client.Features.Application;
  using TransactionProject.Client.Features.Counter;
  using TransactionProject.Client.Features.WeatherForecast;
  using TransactionProject.Client.Features.EventStream;
  using TransactionProject.Client.Features.Transactions;

  /// <summary>
  /// Makes access to the State a little easier and by inheriting from
  /// BlazorStateDevToolsComponent it allows for ReduxDevTools operation.
  /// </summary>
  /// <remarks>
  /// In production one would NOT be required to use these base components
  /// But would be required to properly implement the required interfaces.
  /// one could conditionally inherit from BaseComponent for production build.
  /// </remarks>
  public class BaseComponent : BlazorStateDevToolsComponent
  {
    internal ApplicationState ApplicationState => GetState<ApplicationState>();
    internal CounterState CounterState => GetState<CounterState>();
    internal EventStreamState EventStreamState => GetState<EventStreamState>();
    internal WeatherForecastsState WeatherForecastsState => GetState<WeatherForecastsState>();
    internal TransactionState TransactionState => GetState<TransactionState>();
  }
}