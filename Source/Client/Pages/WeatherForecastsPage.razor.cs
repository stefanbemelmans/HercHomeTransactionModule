namespace TransactionProject.Client.Pages
{
  using System.Threading.Tasks;
  using TransactionProject.Client.Features.Base.Components;
  
  using static TransactionProject.Client.Features.WeatherForecast.WeatherForecastsState;

  public class WeatherForecastsPageBase : BaseComponent
  {
    public const string Route = "/weatherforecasts";

    protected override async Task OnInitializedAsync() =>
      await Mediator.Send(new FetchWeatherForecastsAction());
  }
}