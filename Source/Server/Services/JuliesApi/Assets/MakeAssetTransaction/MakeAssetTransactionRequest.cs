namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using TransactionProject.Api.Features.JuliesApi;

  public class MakeAssetTransactionRequest : IRequest<MakeAssetTransactionResponse>
  {
    public AssetHeaderDto AssetTransaction { get; set; }

    public MakeAssetTransactionRequest()
    {
      AssetTransaction = new AssetHeaderDto();
    }

    //public byte[] Base64Document { get; set; }
    //public string EDit { get; set; }
    //public byte[] ImageByteArray { get; set; } // One for now
    //public List<MetricDefinitionDto> Metrics { get; set; }
  }
}