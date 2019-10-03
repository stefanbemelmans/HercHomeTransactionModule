namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using TransactionProject.Api.Features.JuliesApi;

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
      CreateAssetDefinitionResponse assetDefCreateResponse = await JuliesApi.SendJsonAsync<CreateAssetDefinitionResponse>(HttpMethod.Post, CreateAssetDefinitionApiRequest.CreateAssetEndpoint, aCreateAssetRequest);
       
      return assetDefCreateResponse;
    }
  }
}