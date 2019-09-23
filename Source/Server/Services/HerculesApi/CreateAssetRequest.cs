namespace TransactionProject.Server.Services.HerculesApi
{
  using System.Collections.Generic;

  public class CreateAssetRequest
  {
    public string AssetName { get; set; }
    public byte[] Logo { get; set; }
    public List<Metrics> Metrics { get; set; }
    public string Permissable { get; set; }
  }
}