namespace TransactionProject.Server.Features.JuliesApi
{
  using Microsoft.AspNetCore.Mvc;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;
  using TransactionProject.Server.Features.Base;

  public class MakeAssetTransactionController : BaseController<MakeAssetTransactionApiRequest, MakeAssetTransactionApiResponse>
  {
    public async Task<IActionResult> Process(MakeAssetTransactionApiRequest aRequest) => await Send(aRequest);
  }
}