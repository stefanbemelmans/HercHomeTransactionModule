namespace TransactionProject.Server.Features.JuliesApi
{
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

  public class CreateAssetDefinitionHandler : IRequestHandler<CreateAssetDefinitionApiRequest, CreateAssetDefintionApiResponse>
  {
    private IMediator Mediator { get; set; }

    public CreateAssetDefinitionHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<CreateAssetDefintionApiResponse> Handle
      (CreateAssetDefinitionApiRequest aCreateAssetRequest,
      CancellationToken aCancellationToken
      )
    {
      CreateAssetDefintionApiResponse createAssetDefintionResponse = await Mediator.Send(new CreateAssetDefinitionApiRequest
      {
        AssetDefinitionDto = aCreateAssetRequest.AssetDefinitionDto
      });

      return new CreateAssetDefintionApiResponse
      {
        FactomChainId = createAssetDefintionResponse.FactomChainId,
        IpfsHash = createAssetDefintionResponse.IpfsHash
      };
    }
  }
}