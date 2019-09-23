using System.Collections.Generic;

namespace TransactionProject.Server.Services.HerculesApi
{
  public class AssetDefinition
  {
    /// <summary>
    /// give a name for the asset
    /// </summary>
    public string AssetName { get; set; }
    /// <summary>
    /// an image file sent in multipart/form-data, I'm using the base64 string for now
    /// </summary>
    /// <summary>
    public string Base64StringLogo { get; set; }

    /// a JSON object of metrics up to a maximum of eight unique values. 
    /// Each metric must be labeled as "Metric" plus the number. E.g. {"Metric1": "foo", "Metric2": "bar"}
    /// </summary>
    public List<Metrics> Metrics { get; set; }
    /// <summary>
    /// the username of the allowed person/organization. Must be a current and existing user.
    /// </summary>
    public string Permissable { get; set; }

  }
}