namespace TransactionProject.Server.Services.HerculesApi
{
  using MediatR;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;

  public class CreateAssetHandler : IRequestHandler<CreateAssetRequest, CreateAssetResponse>
  {
    private HttpClient HttpClient { get; set; }

    public CreateAssetHandler(HttpClient aHttpClient)
    {
      HttpClient = aHttpClient;
    }

    public async Task<CreateAssetResponse> Handle
         (
       CreateAssetRequest aCreateAssetRequest,
       CancellationToken aCancellationToken
     )
    {
    }
  }
}