namespace TransactionProject.Server.Services.JuliesApi.Assets.MakeAssetTransaction
{
  using MediatR;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.JuliesApi;

  public class MakeAssetTransactionRequest : IRequest<MakeAssetTransactionResponse>
  {
    public string AssetKey { get; set; }
    public byte[] Base64Document { get; set; }
    public string EDit { get; set; }
    public byte[] ImageByteArray { get; set; } // One for now
    public List<MetricDefinitionDto> Metrics { get; set; }
  }
}