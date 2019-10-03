namespace TransactionProject.Api.Features.JuliesApi
{
  using MediatR;
  using TransactionProject.Api.Features.Base;
  
  public class MakeAssetTransactionApiRequest : BaseRequest, IRequest<MakeAssetTransactionApiResponse>
  {
    public const string MakeTransactionEndpoint = "makeTransaction?api_key=" + TempApiKey.ApiKey; 
    public const string Route = "api/MakeTransaction";

    /// <summary>
    /// The AssetTransactionDto which reflects the AssetTransaction you wish to create
    /// </summary>
    ///

    public MakeAssetTransactionDto MakeAssetTransactionDto { get; set; }
    //public string AssetKey { get; set; }
    //public byte[] Base64Document { get; set; }
    //public string EDit { get; set; }
    //public byte[] ImageByteArray { get; set; } // One for now
    //public List<MetricDefinitionDto> Metrics { get; set; }
  }
}