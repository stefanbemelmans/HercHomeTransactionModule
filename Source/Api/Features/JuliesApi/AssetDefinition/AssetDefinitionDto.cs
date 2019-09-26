namespace TransactionProject.Api.Features.JuliesApi
{
  using System.Collections.Generic;

  public class AssetDefinitionDto
  {
    /// <summary>
    /// Contains the Logo/image that is to represent the AssetDefintion
    /// and the associated Assets
    /// </summary>
    public byte[] Logo { get; set; }

    /// <summary>
    /// The collection of Metrics used to describe `Assest`s associated
    /// to this AssetDefinition
    /// </summary>
    public List<MetricDefinitionDto> MetricDefinitions { get; set; }

    /// <summary>
    /// The Name of the AssetDefinition
    /// </summary>
    /// <example>Rice</example>
    /// <example>Gold</example>
    /// <example>Televisions</example>
    public string Name { get; set; }

    /// <summary>
    /// TODO:
    /// </summary>
    public string Url { get; set; }

    public AssetDefinitionDto()
    {
      MetricDefinitions = new List<MetricDefinitionDto>();
    }

    protected AssetDefinitionDto(AssetDefinitionDto aAssetDefinition) : this()
    {
      Name = aAssetDefinition.Name;
      Url = aAssetDefinition.Url;
      Logo = aAssetDefinition.Logo;

      foreach (MetricDefinitionDto metricDefinition in aAssetDefinition.MetricDefinitions)
      {
        MetricDefinitions.Add((MetricDefinitionDto)metricDefinition.Clone());
      }
    }

    public object Clone() => new AssetDefinitionDto(this);
  }
}