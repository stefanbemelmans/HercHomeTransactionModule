namespace TransactionProject.Api.Features.JuliesApi
{
  using MediatR;
  using TransactionProject.Api.Features.Base;

  public class ReturnTransactionsOnASingleAssetApiRequest : BaseRequest, IRequest<ReturnTransactionsOnASingleAssetApiResponse>
    {
       public const string Route = "api/GetAssetTransactions";
       public const string GetAssetTransactionsEndpoint = "assets/transactions?api_key=" + TempApiKey.ApiKey;

       public string AssetKey { get; set; }
    }
}