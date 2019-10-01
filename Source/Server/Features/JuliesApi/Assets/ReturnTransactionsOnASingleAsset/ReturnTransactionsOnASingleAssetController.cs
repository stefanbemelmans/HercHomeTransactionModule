namespace TransactionProject.Server.Features.JuliesApi
{
  using Microsoft.AspNetCore.Mvc;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;
  using TransactionProject.Server.Features.Base;

  public class ReturnTransactionsOnASingleAssetController : BaseController<ReturnTransactionsOnASingleAssetApiRequest, ReturnTransactionsOnASingleAssetApiResponse>
  {
    public async Task<IActionResult> Process(ReturnTransactionsOnASingleAssetApiRequest aRequest) => await Send(aRequest);
  }
}