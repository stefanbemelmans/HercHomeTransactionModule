namespace TransactionProject.Server.Features.Transactions
{
  using System.Threading.Tasks;
  using TransactionProject.Server.Features.Base;
  using TransactionProject.Api.Features.Transactions;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetTransactionsApiRequest.Route)]
  public class GetTransactionsController : BaseController<GetTransactionsApiRequest, GetTransactionsApiResponse>
  {
    public async Task<IActionResult> Process(GetTransactionsApiRequest aRequest) => await Send(aRequest);
  }
}