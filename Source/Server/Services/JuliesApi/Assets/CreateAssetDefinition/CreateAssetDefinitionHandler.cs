namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;
  using Microsoft.AspNetCore.Components;

  public class CreateAssetDefinitionHandler : IRequestHandler<CreateAssetDefinitionRequest, CreateAssetDefinitionResponse>
  {
    public JuliesApiHttpClient JuliesApi { get; set; }

    public CreateAssetDefinitionHandler(JuliesApiHttpClient aJuliesApi)
    {
      JuliesApi = aJuliesApi;
    }

    public async Task<CreateAssetDefinitionResponse> Handle
         (
       CreateAssetDefinitionRequest aCreateAssetRequest,
       CancellationToken aCancellationToken
     )
    {
      var AssetDefCreateResponse = await JuliesApi.PostJsonAsync<CreateAssetDefinitionResponse>(CreateAssetDefinitionApiRequest.CreateAssetEndpoint + CreateAssetDefinitionApiRequest.ApiKey);
      return AssetDefCreateResponse;
    }
  }
}