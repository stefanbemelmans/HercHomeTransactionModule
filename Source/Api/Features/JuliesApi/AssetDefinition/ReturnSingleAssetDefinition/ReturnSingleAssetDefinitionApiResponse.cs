namespace TransactionProject.Api.Features.JuliesApi
{
  using System;
  using TransactionProject.Api.Features.Base;

  /// <summary>
  /// Returns the AssetDefinitionDto if found
  /// </summary>
  public class ReturnSingleAssetDefinitionApiResponse : BaseResponse
  {
    /// <summary>
    /// The AssetDefintion requested if found else null.
    /// </summary>
    public AssetDefinitionDto AssetDefinition { get; set; }

    public ReturnSingleAssetDefinitionApiResponse() { }

    public ReturnSingleAssetDefinitionApiResponse(Guid aRequestId) : base(aRequestId) { }
  }
}