namespace TransactionProject.Api.Features.JuliesApi.AssetTransaction
{
  using MediatR;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Base;
  using TransactionProject.Api.Features.JuliesApi.AssetTransactions;

  public class MakeAssetTransactionApiRequest : BaseRequest, IRequest<MakeAssetTransactionApiResponse>
  {
    public const string MakeTransactionEndpoint = "makeTransaction?api_key="; // + ApiKey;
    public const string Route = "api/MakeTransaction";

    /// <summary>
    /// The AssetDefintionDto which reflects the AssetDefintion you wish to create
    /// </summary>
    public string AssetKey { get; set; }
    public byte[] Base64Document { get; set; }
    public string EDit { get; set; }
    public byte[] ImageByteArray { get; set; } // One for now
    public List<MetricDefinitionDto> Metrics { get; set; }
  }
}