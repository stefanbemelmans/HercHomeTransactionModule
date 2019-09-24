namespace TransactionProject.Api.Features.AssetDefinition
{
  using System;
  using TransactionProject.Api.Features.Base;

  public class CreateAssetDefinitionResponse : BaseResponse
  {
    public CreateAssetDefinitionResponse() { }
    public CreateAssetDefinitionResponse(Guid aRequestId) : base(aRequestId) { }
    public AssetDefinitionDto AssetDefinition { get; set; }
  }
}