namespace TransactionProject.Server.Features.WeatherForecast
{
  using System.Threading.Tasks;
  using TransactionProject.Server.Features.Base;
  using TransactionProject.Api.Features.WeatherForecast;
  using Microsoft.AspNetCore.Mvc;

  [Route(GeTransactionsRequest.Route)]
  public class GetWeatherForecastsController : BaseController<GeTransactionsRequest, GetWeatherForecastResponse>
  {
    public async Task<IActionResult> Process(GeTransactionsRequest aRequest) => await Send(aRequest);
  }
}