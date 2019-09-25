namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;
  using TransactionProject.Api.Services.JuliesApi;

  public class CreateAssetDefinitionHandler : IRequestHandler<CreateAssetDefinitionRequest, CreateAssetDefinitionResponse>
  {
    private HttpClient HttpClient { get; set; }

    public CreateAssetDefinitionHandler(HttpClient aHttpClient)
    {
      HttpClient = aHttpClient;
    }

    public async Task<CreateAssetDefinitionResponse> Handle
         (
       CreateAssetDefinitionRequest aCreateAssetRequest,
       CancellationToken aCancellationToken
     )
    {
      var AssetDefCreateResponse = await JuliesApiHttpClient.SendJsonAsync(Api.Features.JuliesApi.CreateAssetDefinitionRequest.CreateAssetEndpoint + )
    }
  }
}