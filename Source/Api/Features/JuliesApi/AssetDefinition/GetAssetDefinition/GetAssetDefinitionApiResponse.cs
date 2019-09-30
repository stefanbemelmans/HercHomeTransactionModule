namespace TransactionProject.Api.Features.JuliesApi
{
  using TransactionProject.Api.Features.Base;
  using System;

  /// <summary>
  /// Returns the AssetDefinitionDto if found
  /// </summary>
  public class GetAssetDefinitionApiResponse : BaseResponse
  {
    public GetAssetDefinitionApiResponse() { }

    public GetAssetDefinitionApiResponse(Guid aRequestId) : base(aRequestId) { }

    /// <summary>
    /// The AssetDefintion requested if found else null.
    /// </summary>
    public AssetDefinitionDto AssetDefinition { get; set; }
  }
}