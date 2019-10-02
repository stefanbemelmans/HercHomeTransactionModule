namespace TransactionProject.Server.Features.JuliesApi
{
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnListOfAssetsHandler : IRequestHandler<ReturnListOfAssetsApiRequest, ReturnListOfAssetsApiResponse>
  {
    private IMediator Mediator { get; set; }

    public ReturnListOfAssetsHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<ReturnListOfAssetsApiResponse> Handle
      (
        ReturnListOfAssetsApiRequest aReturnListOfAssetsRequest,
        CancellationToken aCancellationToken
      )
    {
      ReturnListOfAssetsApiResponse returnListOfAssetsApiResponse = await Mediator.Send(new ReturnListOfAssetsApiRequest
      {
        // No param for this request
      });

      return new ReturnListOfAssetsApiResponse
      {
        ListOfAssetHeaders = returnListOfAssetsApiResponse.ListOfAssetHeaders
      };
    }
  }
}