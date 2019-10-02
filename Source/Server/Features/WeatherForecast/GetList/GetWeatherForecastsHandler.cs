namespace TransactionProject.Server.Features.WeatherForecast
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.WeatherForecast;
  using MediatR;

  public class GetWeatherForecastsHandler : IRequestHandler<GetWeatherForecastRequest, GetWeatherForecastResponse>
  {
    private readonly string[] Summaries = new[]
    {
      "Freezing",
      "Bracing",
      "Chilly",
      "Cool",
      "Mild",
      "Warm",
      "Balmy",
      "Hot",
      "Sweltering",
      "Scorching"
    };

    public async Task<GetWeatherForecastResponse> Handle
    (
      GetWeatherForecastRequest aGetWeatherForecastsRequest,
      CancellationToken aCancellationToken
    )
    {
      var response = new GetWeatherForecastResponse(aGetWeatherForecastsRequest.Id);
      var random = new Random();
      var weatherForecasts = new List<WeatherForecastDto>();
      Enumerable.Range(1, aGetWeatherForecastsRequest.Days).ToList().ForEach
      (
        aIndex => response.WeatherForecasts.Add
	    (
          new WeatherForecastDto
          (
            aDate: DateTime.Now.AddDays(aIndex),
            aSummary: Summaries[random.Next(Summaries.Length)],
            aTemperatureC: random.Next(-20, 55)
          )
        )
      );

      return await Task.Run(() => response);
    }
  }
}