﻿namespace TransactionProject.Server.Services.JuliesApi
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnListOfAssetsResponse
  {
    public List<AssetDefinitionDto> ListOfAssets { get; set; }
  }
}