namespace TransactionProject.Api.Features.Transactions
{
  using TransactionProject.Api.Features.Base;
  using MediatR;

  public class GetTransactionsRequest : BaseRequest, IRequest<GetTransactionsResponse>
  {
    public const string Route = "api/transactions";
    /// <summary>
    /// The Number of days of forecasts to get
    /// </summary>
    public string UserName { get; set; } = "julie";
  }
}