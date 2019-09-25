namespace TransactionProject.Server.Services.JuliesApi
{
  using MediatR;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.JuliesApi;

  public class CreateAssetDefinitionRequest : IRequest<CreateAssetDefinitionResponse>
  {
    public string AssetName { get; set; }
    public byte[] Logo { get; set; }
    public List<MetricDefinitionDto> Metrics { get; set; }
    public string Permissable { get; set; }
  }
}