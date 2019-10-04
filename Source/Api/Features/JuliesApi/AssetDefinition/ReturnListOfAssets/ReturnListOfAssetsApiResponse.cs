namespace TransactionProject.Api.Features.JuliesApi
{
  using TransactionProject.Api.Features.Base;
  using System;
  using System.Collections.Generic;

  /// <summary>
  /// Returns the AssetDefinitionDto if found
  /// </summary>
  public class ReturnListOfAssetsApiResponse : BaseResponse
  {
    public ReturnListOfAssetsApiResponse() { }

    public ReturnListOfAssetsApiResponse(Guid aRequestId) : base(aRequestId) { }

    /// <summary>
    /// The AssetDefintion requested if found else null.
    /// </summary>
    public List<SingleAssetHeaderDto> ListOfAssetHeaders { get; set; }
  }
}