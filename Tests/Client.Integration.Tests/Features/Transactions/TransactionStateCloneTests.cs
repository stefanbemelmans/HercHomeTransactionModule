//namespace TransactionProject.Client.Integration.Tests.Features.Transactions
//{
//  using AnyClone;
//  using TransactionProject.Client.Features.Transactions;
//  using TransactionProject.Client.Integration.Tests.Infrastructure;
//  using TransactionProject.Api.Features.Transactions;
//  using BlazorState;
//  using Microsoft.Extensions.DependencyInjection;
//  using Shouldly;
//  using System;
//  using System.Collections.Generic;

//  internal class WeatherForecastStateCloneTests
//  {
//    private TransactionState TransactionState { get; set; }

//    public WeatherForecastStateCloneTests(TestFixture aTestFixture)
//    {
//      IServiceProvider serviceProvider = aTestFixture.ServiceProvider;
//      IStore store = serviceProvider.GetService<IStore>();
//      TransactionState = store.GetState<TransactionState>();
//    }

//    public void ShouldClone()
//    {
//      //Arrange
//      var weatherForecasts = new List<TransactionDto> {
//        new TransactionDto
//        (
//          aDateTime: DateTime.MinValue,
//          aTransactionAmount: 42,
//           aGas: 42,
//          aToAddress: "imaginary 0x Address",
//          aTxId = 42;
//        ),
//        new TransactionDto
//        (
//           aDateTime: DateTime.MinValue,
//          aTransactionAmount: 42,
//           aGas: 42,
//          aToAddress: "imaginary 0x Address",
//          aTxId = 42;
//        )
//      };
//      TransactionState.Initialize(weatherForecasts);

//      //Act
//      var clone = TransactionState.Clone() as TransactionState;

//      //Assert
//      TransactionState.ShouldNotBeSameAs(clone);
//      TransactionState.WeatherForecasts.Count.ShouldBe(clone.WeatherForecasts.Count);
//      TransactionState.Guid.ShouldNotBe(clone.Guid);
//      TransactionState.WeatherForecasts[0].TemperatureC.ShouldBe(clone.WeatherForecasts[0].TemperatureC);
//      TransactionState.WeatherForecasts[0].ShouldNotBe(clone.WeatherForecasts[0]);
//    }
//  }
//}