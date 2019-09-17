namespace TransactionProject.Api.Features.WeatherForecast
{
  using System;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Base;

  public class GetWeatherForecastResponse : BaseResponse
  {
    /// <summary>
    /// a default constructor is required for deserialization
    /// </summary>
    public GetWeatherForecastResponse() { }

    public GetWeatherForecastResponse(Guid aRequestId)
    {
      WeatherForecasts = new List<WeatherForecastDto>();
      RequestId = aRequestId;
    }

    public List<WeatherForecastDto> WeatherForecasts { get; set; }
  }
}