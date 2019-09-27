namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using Microsoft.AspNetCore.Components;
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
      CreateAssetDefinitionResponse assetDefCreateResponse = await JuliesApi.PostJsonAsync<CreateAssetDefinitionResponse>(CreateAssetDefinitionApiRequest.CreateAssetEndpoint, new CreateAssetDefinitionRequest
      {
        AssetDefinition = aCreateAssetRequest.AssetDefinition
      });
      return assetDefCreateResponse;
    }
  }
}