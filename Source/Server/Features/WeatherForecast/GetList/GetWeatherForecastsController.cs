namespace TransactionProject.Server.Features.WeatherForecast
{
  using System.Threading.Tasks;
  using TransactionProject.Server.Features.Base;
  using TransactionProject.Api.Features.WeatherForecast;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetWeatherForecastRequest.Route)]
  public class GetWeatherForecastsController : BaseController<GetWeatherForecastRequest, GetWeatherForecastResponse>
  {
    public async Task<IActionResult> Process(GetWeatherForecastRequest aRequest) => await Send(aRequest);
  }
}