using System.Collections.Generic;

namespace TransactionProject.Server.Services.HerculesApi
{
  public class AssetDefinition
  {
    public string AssetName { get; set; }
    public byte[] Logo { get; set; }
    public List<Metrics> Metrics { get; set; }
  }
}