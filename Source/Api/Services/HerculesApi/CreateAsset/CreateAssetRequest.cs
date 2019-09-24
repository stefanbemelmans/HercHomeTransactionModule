namespace TransactionProject.Api.Services.Transactions
{
  using MediatR;

  public class CreateAssetRequest : IRequest<CreateAssetResponse>
    {
    public int NumberOfTransactions { get; set; } = 10;
  }
}
