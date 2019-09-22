namespace TransactionProject.Api.Features.Transactions
{
  using TransactionProject.Api.Features.Base;
  using MediatR;

  public class GetTransactionsApiRequest : BaseRequest, IRequest<GetTransactionsApiResponse>
  {
    public const string Route = "api/transactions";
    /// <summary>
    /// The UserName If the User is not already logged in.
    /// </summary>
    //public string UserName { get; set; } = "julie";

    public int NumberOfTransactions { get; set; } = 10;
  }
}