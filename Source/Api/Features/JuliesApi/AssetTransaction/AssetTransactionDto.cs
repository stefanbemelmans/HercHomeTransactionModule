using System;
using System.Text.Json.Serialization;

namespace TransactionProject.Api.Features.JuliesApi
{
  public class AssetTransactionDto
  {
    [JsonPropertyName("data")]
    public Data Data { get; set; }
    [JsonPropertyName("header")]
    public Header Header { get; set; }

    public string AssetKey { get; set; }

    public AssetTransactionDto() { }
  }

  public class Data
  {
    [JsonPropertyName("documents")]
    public string Documents { get; set; }
    [JsonPropertyName("images")]
    public string Images { get; set; }
    [JsonPropertyName("metrics")]
    public string Metrics { get; set; }
    [JsonPropertyName("ediT")]
    public string EDiT { get; set; }
    public string GeoLocation { get; set; }


    public Data() { }
  }

  public class Header
  {
    public string AssetId { get; set; }

    public DateTime DTime { get; set; }

    public string FactomEntry { get; set; }

    public int HercId { get; set; }

    public string Name { get; set; }

    public string Price { get; set; }

    public string TxSide { get; set; }

    public Header() { }
  }
}