namespace TransactionProject.Server.Services.HerculesApi
{
  using MediatR;
  using System.Collections.Generic;

  public class CreateAssetRequest : IRequest<CreateAssetResponse>
  {
    public string AssetName { get; set; }
    public byte[] Logo { get; set; }
    public List<Metrics> Metrics { get; set; }
    public string Permissable { get; set; }
  }
}