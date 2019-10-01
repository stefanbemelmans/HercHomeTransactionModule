namespace TransactionProject.Server.Features.JuliesApi
{
  using Microsoft.AspNetCore.Mvc;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;
  using TransactionProject.Server.Features.Base;

  public class ReturnListOfAssetsController : BaseController<ReturnListOfAssetsApiRequest, ReturnListOfAssetsApiResponse>
  {
    public async Task<IActionResult> Process(ReturnListOfAssetsApiRequest aRequest) => await Send(aRequest);
  }
}