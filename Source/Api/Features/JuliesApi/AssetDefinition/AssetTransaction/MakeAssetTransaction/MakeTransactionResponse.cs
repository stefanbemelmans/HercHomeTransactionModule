namespace TransactionProject.Api.Features.JuliesApi.AssetTransactions
{
  using System;
  using TransactionProject.Api.Features.Base;

  public class CreateAssetDefResponse : BaseResponse
  {
    public CreateAssetDefResponse() { }
    public CreateAssetDefResponse(Guid aRequestId) : base(aRequestId) { }
    public AssetDefinitionDto AssetDefinition { get; set; }
  }
}