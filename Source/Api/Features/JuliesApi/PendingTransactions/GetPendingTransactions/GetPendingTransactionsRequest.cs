namespace TransactionProject.Api.Features.PendingTransactions
{
  using TransactionProject.Api.Features.Base;
  using MediatR;

  public class GetPendingTransactionsRequest : BaseRequest, IRequest<GetPendingTransactionsResponse>
  {
    public const string Route = "api/pendingTransactions";
    /// <summary>
    /// The UserName If the User is not already logged in.
    /// </summary>
    //public string UserName { get; set; } = "julie";

    public int NumberOfTransactions { get; set; } = 10;
  }
}