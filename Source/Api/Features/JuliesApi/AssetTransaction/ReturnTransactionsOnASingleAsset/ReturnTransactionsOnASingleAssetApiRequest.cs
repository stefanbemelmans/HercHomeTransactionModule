namespace TransactionProject.Api.Features.JuliesApi
{
  using MediatR;
  using TransactionProject.Api.Features.Base;

  public class ReturnTransactionsOnASingleAssetApiRequest : BaseRequest, IRequest<ReturnTransactionsOnASingleAssetApiResponse>
    {
       public const string Route = "api/GetAssetTransactions";
       public const string GetAssetTransEndpoint = "list?api_key=[*insert key here*]";

       public string AssetKey { get; set; }
    }
}