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
   

    public CreateAssetDefinitionHandler()
    {
    }

    public async Task<CreateAssetDefinitionResponse> Handle
         (
       CreateAssetDefinitionRequest aCreateAssetRequest,
       CancellationToken aCancellationToken
     )
    {
      var AssetDefCreateResponse = await JuliesApiHttpClient.PostJsonAsync<CreateAssetDefinitionResponse>(CreateAssetDefinitionApiRequest.CreateAssetEndpoint + CreateAssetDefinitionApiRequest.ApiKey);
      return AssetDefCreateResponse;
    }
  }
}