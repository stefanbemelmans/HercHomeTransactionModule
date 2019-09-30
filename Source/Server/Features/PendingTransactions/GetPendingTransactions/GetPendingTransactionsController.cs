namespace TransactionProject.Server.Features.PendingTransactions
{
  using System.Threading.Tasks;
  using TransactionProject.Server.Features.Base;
  using TransactionProject.Api.Features.PendingTransactions;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetPendingTransactionsApiRequest.Route)]
  public class GetPendingTransactionsController : BaseController<GetPendingTransactionsApiRequest, GetPendingTransactionsApiResponse>
  {
    public async Task<IActionResult> Process(GetPendingTransactionsApiRequest aRequest) => await Send(aRequest);
  }
}