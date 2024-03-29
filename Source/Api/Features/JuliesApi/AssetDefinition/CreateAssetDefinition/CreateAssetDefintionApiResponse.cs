﻿namespace TransactionProject.Api.Features.JuliesApi
{
  using System;
  using TransactionProject.Api.Features.Base;

  public class CreateAssetDefintionApiResponse : BaseResponse
  {
    public CreateAssetDefintionApiResponse() { }
    public CreateAssetDefintionApiResponse(Guid aRequestId) : base(aRequestId) { }
    public AssetDefinitionDto AssetDefinition { get; set; }
  }
}