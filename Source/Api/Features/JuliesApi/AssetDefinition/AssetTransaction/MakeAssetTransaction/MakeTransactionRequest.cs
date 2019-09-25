namespace TransactionProject.Api.Features.JuliesApi.AssetTransaction
{
  using MediatR;
  using TransactionProject.Api.Features.Base;

  public class MakeTransactionRequest : BaseRequest, IRequest<MakeTransactionResponse>
  {
    public const string MakeTransactionEndpoint = "makeTransaction?api_key="; // + ApiKey;
    public const string Route = "api/MakeTransaction";

    /// <summary>
    /// The AssetDefintionDto which reflects the AssetDefintion you wish to create
    /// </summary>
    public AssetTransactionDto AssetDefinitionDto { get; set; }
  }
}