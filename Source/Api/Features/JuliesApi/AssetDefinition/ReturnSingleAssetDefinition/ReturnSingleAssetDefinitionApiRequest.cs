﻿namespace TransactionProject.Api.Features.JuliesApi
{
  using TransactionProject.Api.Features.Base;
  using MediatR;

  /// <summary>
  /// Get an AssetDefinition by AssetKey
  /// </summary>
  public class ReturnSingleAssetDefintionApiRequest : BaseRequest, IRequest<ReturnSingleAssetDefinitionApiResponse>
  {
    public const string Route = "api/ReturnSingleAssetDefinition";
    public const string ReturnSingleAssetDefinitionEndpoint = "/transactions?api-key=" + TempApiKey.ApiKey;
    /// <summary>
    /// The AssetDefinition Key to get. 
    /// </summary>
    public int AssetKey { get; set; }
  }
}