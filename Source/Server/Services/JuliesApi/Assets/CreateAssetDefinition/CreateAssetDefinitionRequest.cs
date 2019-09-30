namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.JuliesApi;

  public class CreateAssetDefinitionRequest : IRequest<CreateAssetDefinitionResponse>
  {

    public AssetDefinitionDto AssetDefinition { get; set; }

    public CreateAssetDefinitionRequest()
    {
      AssetDefinition = new AssetDefinitionDto();
    }
    //public string AssetName { get; set; }
    //public byte[] Logo { get; set; }
    //public List<MetricDefinitionDto> Metrics { get; set; }
    //public string Permissable { get; set; }
  }
}