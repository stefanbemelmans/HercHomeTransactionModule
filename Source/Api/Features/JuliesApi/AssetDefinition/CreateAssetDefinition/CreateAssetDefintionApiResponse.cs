namespace TransactionProject.Api.Features.JuliesApi
{
  using System;
  using TransactionProject.Api.Features.Base;

  public class CreateAssetDefintionApiResponse : BaseResponse
  {
    public CreateAssetDefintionApiResponse() { }
    public CreateAssetDefintionApiResponse(Guid aRequestId) : base(aRequestId) { }
    public string FactomChainId { get; set; }

    public string IpfsHash { get; set; }
  }
}