namespace TransactionProject.Api.Features.WeatherForecast
{
  using TransactionProject.Api.Features.Base;
  using MediatR;

  public class GetWeatherForecastRequest : BaseRequest, IRequest<GetWeatherForecastResponse>
  {
    public const string Route = "api/weatherForecast";
    /// <summary>
    /// The Number of days of forecasts to get
    /// </summary>
    public int Days { get; set; }
  }
}