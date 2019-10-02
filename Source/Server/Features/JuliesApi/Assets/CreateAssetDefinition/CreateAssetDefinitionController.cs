namespace TransactionProject.Server.Features.JuliesApi
{
  using Microsoft.AspNetCore.Mvc;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;
  using TransactionProject.Server.Features.Base;
  [Route(CreateAssetDefinitionApiRequest.Route)]
  public class CreateAssetDefinitionController : BaseController<CreateAssetDefinitionApiRequest, CreateAssetDefintionApiResponse>
  {
    public async Task<IActionResult> Process(CreateAssetDefinitionApiRequest aRequest) => await Send(aRequest);
  }
}